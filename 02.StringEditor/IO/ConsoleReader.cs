namespace _02.StringEditor.IO
{
    using System;
    using Interfaces;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            var line = Console.ReadLine();

            return line;
        }
    }
}