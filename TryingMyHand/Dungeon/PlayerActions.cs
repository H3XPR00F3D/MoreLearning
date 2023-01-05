using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MoreLearning.Dungeon
{
    internal class PlayerActions
    {
        public static int wait = Prompts.wait;
        public static string text;

        public static void EscapeCell()
        {
            Console.WriteLine();
            Console.Clear();
            text = ("What action would you like to take?");
            SlowPrint.Print();

            int doorHealth = 5;
            do
            {

                Console.WriteLine();
                Console.WriteLine();
                text = "**************************\n|  (J)iggle  (C)all out  |\n|        (S)houlder      |\n**************************";
                SlowPrint.Print();
                Console.WriteLine();
                Console.WriteLine("        (L)eave");
                string input = Console.ReadLine();
                Console.WriteLine();

                if (input.ToLower() == "j" || input.ToLower() == "jiggle")
                {
                    doorHealth--;
                    Console.Clear();
                    text = "You vigorously jiggle the bars.";
                    SlowPrint.Print();

                    if (doorHealth < 5 && doorHealth > 0) { Console.WriteLine(); text = "You can feel the bars give a little. Maybe shake it some more."; SlowPrint.Print(); }

                }
                else if (input.ToLower() == "c" || input.ToLower() == "call out")
                {
                    Console.WriteLine(); text = "You call out down the hall, but all you hear is your own voice echoing off the walls."; SlowPrint.Print(); ;
                    if (doorHealth <= 5) { Console.WriteLine(); text = "Letting your captors know you are awake does not give you any solace. You should try something else."; SlowPrint.Print(); }
                }

                else if (input.ToLower() == "s" || input.ToLower() == "shoulder")
                {
                    doorHealth -= 2;
                    Console.Clear();
                    Console.WriteLine(); text = "You take a few steps back, dip your strong shoulder and charge...."; SlowPrint.Print();
                    if (doorHealth > 0 && doorHealth < 5) { Console.WriteLine(); text = "That did something. The barred area has shaken and is very much looser. A few more of those should do the trick."; SlowPrint.Print(); }
                }

                else if (input.ToLower() == "l" || input.ToLower() == "leave")
                {
                    Console.WriteLine(text = "You let go of the bars and step back, looking into the small, dark room. It is very tiny, only enough room to take a few steps, or lay against the wall."); SlowPrint.Print();
                    if (doorHealth > 0 && doorHealth <= 5) { Console.WriteLine(); text = "You might want to try the bars again. There isn't much else going on."; SlowPrint.Print(); }
                }
            }
            while (doorHealth > 0);

            if (doorHealth <= 0)
            {

                Console.WriteLine();
                Console.WriteLine();
                text = "The bars crash outward towards the ground. The metal slams against the stone floor and the sound fills the long hall.";
                SlowPrint.Print();

            }

        }





        public class SlowPrint
        {
            public static void Print()
            {
                //prints lines character by character
                foreach (char c in text)
                {
                    Console.Write(c);
                    Thread.Sleep(wait);
                }
            }
        }
    }
}
