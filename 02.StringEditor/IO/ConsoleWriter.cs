namespace _02.StringEditor.IO
{
    using System;
    using Interfaces;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string message, params object[] @params)
        {
            Console.WriteLine(message, @params);
        }
    }
}