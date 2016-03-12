namespace _02.StringEditor
{
    using Core;
    using Interfaces;
    using IO;
    using Models;

    public static class StringEditorDemo
    {
        public static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IStringEditor stringEditor = new StringEditor();
            IAppController appController = new AppController(stringEditor);

            IApp app = new App(
                reader,
                writer,
                appController);

            app.Run();
        }
    }
}
