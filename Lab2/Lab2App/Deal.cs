using System.Globalization;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Lab2App;

public class Deal
{
    public long Id { get; set; }
    public string title { get; set; }
    public string worth { get; set; }
    public string thumbnail { get; set; }
    public string description { get; set; } 
    public string instructions { get; set; }
    
    [JsonProperty(PropertyName = "open_giveaway_url")]
    public string url { get; set; }
    
    public string type { get; set; }
    [JsonProperty(PropertyName = "platforms"), BsonIgnore]
    public string platformString { get; set; }
    [BsonElement] 
    public HashSet<string> device = new HashSet<string>();
    [BsonElement]
    public HashSet<string> platform = new HashSet<string>();
    
    [JsonProperty(PropertyName="published_date")]
    public string publicationDateString { get; set; }
    
    [JsonProperty(PropertyName="end_date")]
    public string endDateString { get; set; }
    
    [BsonElement]
    public DateTime? publicationDate => ConvertStringToDate(publicationDateString);
    [BsonElement]
    public DateTime? endDate => ConvertStringToDate(endDateString);
    
    [BsonIgnore]
    public string status { get; set; }
    [BsonElement]
    
    public bool isActive => status.Equals("Active", StringComparison.OrdinalIgnoreCase);
    
    private DateTime? ConvertStringToDate(string dateString)
    {
        if (string.Equals(dateString, "N/A", StringComparison.OrdinalIgnoreCase))
        {
            return null;
        }

        DateTime dt;
        if (DateTime.TryParseExact(dateString, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
        {
            return dt;
        }

        return null;
    }

    public void ClassifyPlatforms()
    {
        var platformsArray = this.platformString.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        
        foreach (var p in platformsArray)
        {
            if (PlatformSingleton.Instance.PcPlatforms.Contains(p, StringComparer.OrdinalIgnoreCase))
            {
                this.device.Add("PC");
                if (!p.Equals("PC"))
                {
                    this.platform.Add(p);
                }
            }
            else if (PlatformSingleton.Instance.MobilePlatforms.Contains(p, StringComparer.OrdinalIgnoreCase))
            {
                this.device.Add("Mobile");
                this.platform.Add(p);
            }
            else if (PlatformSingleton.Instance.ConsolePlatforms.Contains(p, StringComparer.OrdinalIgnoreCase))
            {
                this.device.Add("Console");
                this.platform.Add(p);
            }
            else
            {
                this.device.Add("VR");
            }
        }
    }
}