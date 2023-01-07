using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Dungeon
{
    internal class PromptPrint
    {
        public static int wait = 5;
        public static string text;

        public static void Print()
        {
            //prints lines character by character
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(wait);
            }

        }
        public static void Continue()
        {
            Console.WriteLine("Press Enter to continue.");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            while (keyInfo.Key != ConsoleKey.Enter)
                keyInfo = Console.ReadKey();
        }
    }
}
