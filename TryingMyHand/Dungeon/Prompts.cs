using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Dungeon
{
     class Prompts
    {
       // public variables for Prompts. Wait is the amount of milliseconds to wait between each character is printed.
        public static int wait = 0;
        public static string text;
        public static int playerLvl = Engine.playerLvl;

        //Character printer for text strings. Uses 'wait' and 'text' values.
        public class PromptPrint
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

            public static void Continue()
            {
                Console.WriteLine("Press Enter to continue.");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                while (keyInfo.Key != ConsoleKey.Enter)
                    keyInfo = Console.ReadKey();
            }
        }

        //Anything pasting engine text (story and values) or runs the system.
        public class EnginePrompts
        {
            public static Player currentPlayer = new();
            public static void TitleCard()
            {
                text = ("The Dungeon");
                PromptPrint.Print();

                Console.WriteLine();
            }

            public static void Naming()
            {
                text = ("What is the name of your Character?");
                PromptPrint.Print();
                Console.WriteLine();
                text = ("Name: ");
                PromptPrint.Print();
               
                currentPlayer.name = (Console.ReadLine());

                Console.WriteLine();
            }

            public static void Awaken()
            {
                Console.Clear();
                text = (" 1) Wake Up!");

                PromptPrint.Print();
                Console.WriteLine();
                Console.WriteLine();
                text = ("You awaken in a cold, dark room. You feel the touch of stone against your skin. Your eyes flutter open into the \ndarkness. As they struggle for purchase on your surroundings, small pricks of light start to appear in a line in \nthe distance. You stand, dazed and weak in the knees. As your legs regain their strength, a realization comes to you. \nYou remember nothing...  ");
                PromptPrint.Print();
                Console.WriteLine();
                Console.WriteLine(); 

                if (currentPlayer.name == "") { text = ("...not even your name."); }
                else { text = ("...except your name, " + currentPlayer.name + "."); }
                PromptPrint.Print();
            }

            public static void CellInspect()
            {
                Console.Clear();
                text = ("Your eyes, now acclimated to the dark around you, and your strength and health returning, you take a few solid steps towards the points of light, your hands groping in front of you. Grasping out, you wrap your finger over a cold and pitted metal bar, running vertically and continuing upwards beyond your reach.\n\nRunning your fingers along the bar you touch a second horizontal bar, and follow it to the left. About 6 inches away from the vertical bar is another. Your shoulder presses against the left wall and your hands grasp out and grab the contiuous vertical poles. However, These bars jiggle and are able to move, but are stuck in place.");
                PromptPrint.Print();
            }
        }

        //Anything concerning encounter text.
        public class PlayerRecords
        {
         
            public static void PlayerLvlExp()
            {
                text = ("   Lvl: " +  playerLvl + "     Exp: " + Engine.currentPlayer.playerExp+"\n");
                PromptPrint.Print();
            }

            public static void PlayerInventory()
            {
                text = ("  Potions: " + Engine.currentPlayer.potion + " Health: " + Engine.currentPlayer.health + "\n");
                PromptPrint.Print();
            }
        }
        
    }
}
