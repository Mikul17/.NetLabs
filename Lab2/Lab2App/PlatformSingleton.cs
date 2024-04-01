namespace Lab2App;

public class PlatformSingleton
{
    private static PlatformSingleton instance;
    public static PlatformSingleton Instance => instance ?? (instance = new PlatformSingleton());
    
    public HashSet<string> PcPlatforms { get; private set; }
    public HashSet<string> MobilePlatforms { get; private set; }
    public HashSet<string> ConsolePlatforms { get; private set; }
    public HashSet<string> VrPlatforms { get; private set; }
    public HashSet<string> DealType { get; private set; }
    
    private PlatformSingleton()
    {
        PcPlatforms =  new HashSet<string>()
        {
            "PC", "Steam", "Epic games store", "Ubisoft Connect", "Gog", "Itch.io","Battle.net","Origin","DRM-Free"
        };
        MobilePlatforms = new HashSet<string>()
        {
            "Android", "iOS"
        };
        ConsolePlatforms = new HashSet<string>()
        {
            "Playstation 4", "Playstation 5", "Xbox One", "Xbox Series X|S", "Nintendo Switch", "Xbox 360"
        };
        VrPlatforms = new HashSet<string>() {"VR"};
        DealType = new HashSet<string>()
        {
            "DLC", "Game", "Early Access"
        };
    }


}