using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Hangman.IO
{
    public class FileReader : IReader
    {
        public string[] CustomReadAllLines()
        {
            string[] words = File.ReadAllLines("words.txt");

            return words;
        }

        public string CustomReadLine()
        {
            throw new NotImplementedException();
        }
    }
}
