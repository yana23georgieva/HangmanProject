using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman.IO
{
    public class ConsoleReader : IReader
    {
        public string[] CustomReadAllLines()
        {
            throw new NotImplementedException();
        }

        public string CustomReadLine()
        {
            return Console.ReadLine();
        }
    }
}
