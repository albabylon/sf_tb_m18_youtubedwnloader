using YoutubeExplode;

public class Program
{
    public static void Main(string[] args)
    {
        var youtubeClient = new YoutubeClient();
        var videoClient = youtubeClient.Videos;
    }
}
