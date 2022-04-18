using Hangman.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            FileReader file = new FileReader();
            ConsoleWriter writer = new ConsoleWriter();
            ConsoleReader reader = new ConsoleReader();

            string[] words = file.CustomReadAllLines();

            int index = random.Next(0, words.Length);
            string randomWord = words[index];

            for (int i = 0; i < randomWord.Length; i++)
            {
                writer.CustomWrite("_ ");
            }

            List<char> allLetters = new List<char>();
            int errors = 0;

            while (errors < 6)
            {
                writer.CustomWrite("Letters guess so far: ");
                writer.CustomWriteLine(string.Join(" ", allLetters));
                writer.CustomWrite("Guess letter: ");

                char letter = reader.CustomReadLine()[0];

                if (allLetters.Contains(letter))
                {
                    writer.CustomWriteLine($"The letter exist.");
                }
                else
                {
                    if (!randomWord.Contains(letter))
                    {
                        errors++;
                    }

                    allLetters.Add(letter);
                }

                writer.CustomWriteLine(PrintWord(randomWord, allLetters));
                writer.CustomWriteLine(PrintHangman(errors));

                if (allLetters.Count - errors == randomWord.Length)
                {
                    break;
                }
            }

            if (errors == 6)
            {
                writer.CustomWriteLine("You lose. Good luck next time!");
            }
            else
            {
                writer.CustomWriteLine("You won. Congratulations!");
            }
        }

        private static string PrintHangman(int errors)
        {
            StringBuilder sb = new StringBuilder();

            if (errors == 0)
            {
                sb.AppendLine("-----");
                sb.AppendLine("    |");
                sb.AppendLine("    |");
                sb.AppendLine("    |");
                sb.AppendLine("   ---");
            }
            else if (errors == 1)
            {
                sb.AppendLine("-----");
                sb.AppendLine(" o  |");
                sb.AppendLine("    |");
                sb.AppendLine("    |");
                sb.AppendLine("   ---");
            }
            else if (errors == 2)
            {
                sb.AppendLine("-----");
                sb.AppendLine(" o  |");
                sb.AppendLine(" |  |");
                sb.AppendLine("    |");
                sb.AppendLine("   ---");
            }
            else if (errors == 3)
            {
                sb.AppendLine("-----");
                sb.AppendLine(" o  |");
                sb.AppendLine("/|  |");
                sb.AppendLine("    |");
                sb.AppendLine("   ---");
            }
            else if (errors == 4)
            {
                sb.AppendLine("-----");
                sb.AppendLine(" o  |");
                sb.AppendLine("/|\\ |");
                sb.AppendLine("    |");
                sb.AppendLine("   ---");
            }
            else if (errors == 5)
            {
                sb.AppendLine("-----");
                sb.AppendLine(" o  |");
                sb.AppendLine("/|\\ |");
                sb.AppendLine("/   |");
                sb.AppendLine("   ---");
            }
            else if (errors == 6)
            {
                sb.AppendLine("-----");
                sb.AppendLine(" o  |");
                sb.AppendLine("/|\\ |");
                sb.AppendLine("/ \\ |");
                sb.AppendLine("   ---");
            }

            return sb.ToString();
        }

        private static string PrintWord(string randomWord, List<char> allLetters)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in randomWord)
            {
                if (allLetters.Contains(item))
                {
                    sb.Append(item);
                }
                else
                {
                    sb.Append("_");
                }
                sb.Append(" ");
            }

            sb.Append(Environment.NewLine);

            return sb.ToString();
        }
    }
}
