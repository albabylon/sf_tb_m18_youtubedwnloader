using sf_tb_m18_youtubedwnloader.Abstract;

namespace sf_tb_m18_youtubedwnloader.Models.Invoker
{
    /// <summary>
    /// Класс вызывающий команды (Invoker/Sender)
    /// </summary>
    public class CommandInvoker
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public async Task Start() //если у команды будет еще методы, например отмены, то будет еще метод
        {
            await command.Execute();
        }
    }
}
