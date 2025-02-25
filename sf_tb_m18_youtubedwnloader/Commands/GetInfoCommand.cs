using sf_tb_m18_youtubedwnloader.Abstract;
using sf_tb_m18_youtubedwnloader.Models.Receiver;

namespace sf_tb_m18_youtubedwnloader.Commands
{
    public class GetInfoCommand : ICommand
    {
        private readonly YoutubeService youtubeService;

        public GetInfoCommand(YoutubeService youtubeService)
        {
            this.youtubeService = youtubeService;
        }

        public async Task Execute()
        {
            var info = await youtubeService.GetInfo();

            Console.WriteLine($"{info.Author}\n{info.Name} - {info.Duration}\n{info.Description}");
        }
    }
}
