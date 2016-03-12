namespace _02.StringEditor.Core
{
    using System;
    using Interfaces;

    public class App : IApp
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IAppController appController;

        public App(
            IReader reader, 
            IWriter writer, 
            IAppController appController)
        {
            this.reader = reader;
            this.writer = writer;
            this.appController = appController;
        }

        public void Run()
        {
            while (true)
            {
                var inputLine = this.reader.ReadLine().Trim();
                if (string.IsNullOrEmpty(inputLine))
                {
                    this.writer.WriteLine("Invalid input");
                    continue;
                }

                try
                {
                    var commandResult = this.appController.DispatchCommand(inputLine);
                    this.writer.WriteLine(commandResult);
                }
                catch (Exception ex)
                {
                    this.writer.WriteLine(ex.Message);
                }
            }
        }
    }
}