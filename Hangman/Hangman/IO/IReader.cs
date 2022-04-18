using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman.IO
{
    public interface IReader
    {
        string CustomReadLine();
        string[] CustomReadAllLines();
    }
}
