using Newtonsoft.Json;
namespace Lab2App;

public class HttpServiceProvider
{
    private HttpClient client;
    private String baseURL = Environment.GetEnvironmentVariable("BASE_URL");

    public HttpServiceProvider()
    {
        client = new HttpClient();
    }

    public async Task<List<Deal>> QueryAllGames()
    {
        string call = baseURL + "/giveaways";

        try
        {
            HttpResponseMessage response = await client.GetAsync(call);
            if (response.IsSuccessStatusCode)
            {
                string jsonContent = await response.Content.ReadAsStringAsync();
                List<Deal> games = JsonConvert.DeserializeObject<List<Deal>>(jsonContent);
                foreach (var g in games)
                {
                    g.ClassifyPlatforms();
                }
                return games;
            }else {
                Console.WriteLine("|ERROR| Server returned error code: " + response.StatusCode);
                return new List<Deal>();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("|ERROR| ERROR WHILE FETCHING DATA: " + e.Message);
            return new List<Deal>();
        }
    }
}