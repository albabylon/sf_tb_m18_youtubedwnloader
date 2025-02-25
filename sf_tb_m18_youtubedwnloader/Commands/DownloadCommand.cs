using sf_tb_m18_youtubedwnloader.Abstract;
using sf_tb_m18_youtubedwnloader.Models.Receiver;

namespace sf_tb_m18_youtubedwnloader.Commands
{
    public class DownloadCommand : ICommand
    {
        private readonly YoutubeService youtubeService;

        public DownloadCommand(YoutubeService youtubeService)
        {
            this.youtubeService = youtubeService;
        }

        public void Execute()
        {
            youtubeService.DownloadVideo();
        }
    }
}
