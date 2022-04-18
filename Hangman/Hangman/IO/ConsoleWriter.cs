using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman.IO
{
    class ConsoleWriter : IWriter
    {
        public void CustomWrite(string text)
        {
            Console.Write(text);
        }

        public void CustomWriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
