using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PoePart1._1
{
    internal class ConsoleUI
    {
        public static void PrintHeader(string title)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n============================================================");
            Console.WriteLine($"   {title.ToUpper()}");
            Console.WriteLine("============================================================\n");
            Console.ResetColor();
        }

        public static void PrintDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("------------------------------------------------------------");
            Console.ResetColor();
        }

        public static void TypeWriteLine(string text, ConsoleColor color = ConsoleColor.White, int delayMs = 20)
        {
            Console.ForegroundColor = color;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delayMs); // Simulates conversational typing
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void WriteError(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[!] {text}");
            Console.ResetColor();
        }
    }
}
