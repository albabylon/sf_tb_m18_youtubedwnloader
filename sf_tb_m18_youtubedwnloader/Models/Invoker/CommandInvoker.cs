using sf_tb_m18_youtubedwnloader.Abstract;

namespace sf_tb_m18_youtubedwnloader.Models.Invoker
{
    public class CommandInvoker
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void GetInfo()
        {

        }

        public void Download()
        {

        }
    }
}
