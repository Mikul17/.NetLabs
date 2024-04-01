using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Lab2App;

public class DatabaseManager
{
    public IMongoCollection<Deal> Deal { get; set; }

    public DatabaseManager() { }
    
    private void Connect()
    {
        string connectionString = Environment.GetEnvironmentVariable("DB_URI");
        var dbClient = new MongoClient(connectionString);
        string dbName = Environment.GetEnvironmentVariable("DATABASE");
        string collectionName = Environment.GetEnvironmentVariable("COLLECTION");
        this.Deal = dbClient.GetDatabase(dbName).GetCollection<Deal>(collectionName);
    }

    public static async Task<DatabaseManager> InitializeAsync()
    {
        var manager = new DatabaseManager();
        manager.Connect();
        await manager.InitDatabaseDataAsync();
        return manager;
    }
    private async Task InitDatabaseDataAsync()
    {
        var documentsCount = Deal.CountDocuments(FilterDefinition<Deal>.Empty);

        if (documentsCount == 0)
        {
            HttpServiceProvider hps = new HttpServiceProvider();
            List<Deal> games = await hps.QueryAllGames();

            if (games != null && games.Any())
            {
                Deal.InsertMany(games);
            }
        }
    }
    public async Task<List<Deal>> queryPage(int page, int pageSize)
    {
        int skip = (page - 1) * pageSize;
        
        return await Deal.Find(_ => true)
            .Skip(skip)
            .Limit(pageSize)
            .ToListAsync();;
    }
    
    public async Task<List<Deal>> QueryDeals(string fraze, string device, string platform, string type, DateTime time, bool active, int pageNumber, int pageSize)
    {
        var filterBuilder = Builders<Deal>.Filter;
        var filters = new List<FilterDefinition<Deal>>();
        DateTime dat = new DateTime();

        if (!string.IsNullOrWhiteSpace(fraze))
        {
            filters.Add(filterBuilder.Regex(deal => deal.title, new BsonRegularExpression(fraze, "i")));
        }

        if (!string.IsNullOrWhiteSpace(device))
        {
            var regexFilter = Builders<Deal>.Filter.Regex(deal => deal.device, new BsonRegularExpression(device, "i"));
            filters.Add(regexFilter);
        }
        if (!string.IsNullOrWhiteSpace(platform))
        {
            var regexFilter = Builders<Deal>.Filter.Regex(deal => deal.platform, new BsonRegularExpression(platform, "i"));
            filters.Add(regexFilter);
        }
        
        if (!string.IsNullOrWhiteSpace(type))
        {
            filters.Add(filterBuilder.Regex(deal => deal.type, new BsonRegularExpression(type, "i")));
        }

        if (time != dat)
        {
            filters.Add(filterBuilder.Gt(deal => deal.publicationDate, time));
        }

        if (active)
        {
            filters.Add(filterBuilder.Eq(deal => deal.isActive, active));
        }

        var filter = filters.Count > 0 ? filterBuilder.And(filters) : filterBuilder.Empty;

        return await Deal.Find(filter)
            .Skip((pageNumber - 1) * pageSize)
            .Limit(pageSize)
            .ToListAsync();
    }
    
    public async Task<long> CountFilteredDeals(string fraze, string device, string platform, string type, DateTime time, bool active)
    {
        var filterBuilder = Builders<Deal>.Filter;
        var filters = new List<FilterDefinition<Deal>>();
        DateTime dat = new DateTime();

        if (!string.IsNullOrWhiteSpace(fraze))
        {
            filters.Add(filterBuilder.Regex(deal => deal.title, new BsonRegularExpression(fraze, "i")));
        }

        if (!string.IsNullOrWhiteSpace(device))
        {
            var regexFilter = Builders<Deal>.Filter.Regex(deal => deal.device, new BsonRegularExpression(device, "i"));
            filters.Add(regexFilter);
        }
        if (!string.IsNullOrWhiteSpace(platform))
        {
            var regexFilter = Builders<Deal>.Filter.Regex(deal => deal.platform, new BsonRegularExpression(platform, "i"));
            filters.Add(regexFilter);
        }
        
        if (!string.IsNullOrWhiteSpace(type))
        {
            filters.Add(filterBuilder.Regex(deal => deal.type, new BsonRegularExpression(type, "i")));
        }

        if (time != dat)
        {
            filters.Add(filterBuilder.Gt(deal => deal.publicationDate, time));
        }

        if (active)
        {
            filters.Add(filterBuilder.Eq(deal => deal.isActive, active));
        }

        var filter = filters.Count > 0 ? filterBuilder.And(filters) : filterBuilder.Empty;

        return await Deal.CountDocumentsAsync(filter);
    }
}