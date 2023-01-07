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
        public static int wait = PromptPrint.wait;
        

        public static void EscapeCell()
        {
            Console.WriteLine();
            Console.Clear();
            PromptPrint.text = ("What action would you like to take?");
            PromptPrint.Print();

            int doorHealth = 5;
            do
            {
       
                Console.WriteLine();
                Console.WriteLine();
                PromptPrint.text = "**************************\n|  (J)iggle  (C)all out  |\n|        (S)houlder      |\n**************************";
                PromptPrint.Print();
                Console.WriteLine();
                Console.WriteLine("        (L)eave");
                string input = Console.ReadLine();
                Console.WriteLine();

                if (input.ToLower() == "j" || input.ToLower() == "jiggle")
                {
                    doorHealth--;
                    Console.Clear();
                    PromptPrint.text = "You vigorously jiggle the bars.";
                    PromptPrint.Print();

                    if (doorHealth < 5 && doorHealth > 0) { Console.WriteLine(); PromptPrint.text = "You can feel the bars give a little. Maybe shake it some more."; PromptPrint.Print(); }

                }
                else if (input.ToLower() == "c" || input.ToLower() == "call out")
                {
                    Console.Clear();
                    Console.WriteLine(); PromptPrint.text = "You call out down the hall, but all you hear is your own voice echoing off the walls."; PromptPrint.Print() ;
                    if (doorHealth <= 5) { Console.WriteLine(); PromptPrint.text = "Letting your captors know you are awake does not give you any solace. You should try something else."; PromptPrint.Print(); }
                }

                else if (input.ToLower() == "s" || input.ToLower() == "shoulder")
                {
                    doorHealth -= 2;
                    Console.Clear();
                    Console.WriteLine(); PromptPrint.text = "You take a few steps back, dip your strong shoulder and charge...."; PromptPrint.Print();
                    if (doorHealth > 0 && doorHealth < 5) { Console.WriteLine(); PromptPrint.text = "That did something. The barred area has shaken and is very much looser. A few more of those should do the trick."; PromptPrint.Print(); }
                }

                else if (input.ToLower() == "l" || input.ToLower() == "leave")
                {
                    Console.WriteLine(); PromptPrint.text = "You let go of the bars and step back, looking into the small, dark room. It is very tiny, only enough room to take a few steps, or lay against the wall."; PromptPrint.Print();
                    if (doorHealth > 0 && doorHealth <= 5) { Console.WriteLine(); PromptPrint.text = "You might want to try the bars again. There isn't much else going on."; PromptPrint.Print(); }
                }
            }
            while (doorHealth > 0);

            if (doorHealth <= 0)
            {

                Console.WriteLine();
                Console.WriteLine();
                PromptPrint.text = "The bars crash outward towards the ground. The metal slams against the stone floor and the sound fills the long hall.";
                PromptPrint.Print();

            }

        }





        
    }
}
