namespace _03.FastSearchForStringsInTextFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public static class FastSearchForStringsInTextFile
    {
        private const string TextFile = @"../../input_text_zero.txt";
        private const string NeedlesFile = @"../../input_needles_zero.txt";

        // Uncomment to test with larger text file
        // private const string TextFile = @"../../input_text.txt";
        // private const string NeedlesFile = @"../../input_needles.txt";

        public static void Main()
        {
            var search = new AhoCorasickSearch();
            using (var readerText = new StreamReader(TextFile, Encoding.UTF8))
            {
                var text = readerText.ReadToEnd().ToLower();
                var needles = File.ReadAllLines(NeedlesFile);
                var lowerCaseNeedles = needles
                    .Select(row => row.ToLower())
                    .ToArray();

                var res = search.SearchAll(text, lowerCaseNeedles);
                var ocurrences = new Dictionary<string, int>();

                foreach (var needle in lowerCaseNeedles)
                {
                    ocurrences[needle] = 0;
                }

                foreach (var searchResult in res)
                {
                    var currentWord = searchResult.Match;
                    ocurrences[currentWord]++;
                }

                foreach (var needle in needles)
                {
                    Console.WriteLine($"{needle} -> {ocurrences[needle.ToLower()]}");
                }
            }
        }
    }
}
