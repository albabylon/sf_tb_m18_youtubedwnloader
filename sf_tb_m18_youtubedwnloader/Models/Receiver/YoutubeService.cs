using System.Net;
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace sf_tb_m18_youtubedwnloader.Models.Receiver
{
    /// <summary>
    /// Класс получателя команд (Reciever)
    /// </summary>
    public class YoutubeService
    {
        private readonly string url;
        private readonly YoutubeClient youtubeClient;
        private readonly VideoClient videoClient;

        public YoutubeService(string url)
        {
            this.url = url;
            youtubeClient = new YoutubeClient();
            //youtubeClient = SetProxyConnect();
            videoClient = youtubeClient.Videos;
        }

        public async Task<YoutubeVideoData> GetInfo()
        {
            var video = await videoClient.GetAsync(url);

            return new YoutubeVideoData
            {
                Author = video.Author.ChannelTitle,
                Name = video.Title,
                Description = video.Description,
                Duration = string.Format
                (
                    "{0}:{1}:{2}:{3}",
                    video.Duration!.Value.Hours,
                    video.Duration!.Value.Minutes,
                    video.Duration!.Value.Seconds,
                    video.Duration!.Value.Milliseconds
                )
            };
        }

        public async Task DownloadVideo()
        {
            var video = await videoClient.GetAsync(url);

            var streamManifest = await videoClient.Streams.GetManifestAsync(video.Id);
            var stream = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            if (stream == null)
                Console.WriteLine("Проблема! Видео не скачать");

            await videoClient.Streams.DownloadAsync(stream, video.Title);
        }

        [Obsolete]
        private YoutubeClient SetProxyConnect()
        {
            var proxy = new WebProxy("http://85.215.64.49:80");
            var httpClient = new HttpClient(new HttpClientHandler { Proxy = proxy });
            return new YoutubeClient(httpClient);
        }
    }
}
