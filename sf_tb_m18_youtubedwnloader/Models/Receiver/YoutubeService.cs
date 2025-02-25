namespace sf_tb_m18_youtubedwnloader.Models.Receiver
{
    /// <summary>
    /// Класс получателя команд (Reciever)
    /// </summary>
    public class YoutubeService
    {
        private string url;

        public YoutubeService(string url)
        {
            this.url = url;
        }

        public YoutubeVideoData GetInfo()
        {
            var videoData = new YoutubeVideoData();

            return videoData;
        }

        public void DownloadVideo()
        {

        }
    }
}
