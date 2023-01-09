using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Dungeon
{
    //Anything concerning encounter text.
    public class Prompts
    {
        //public static Player currentPlayer = new();
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
        public static void PlayerLvlExp()
        {
           
            text = ("   Lvl: " + Engine.currentPlayer.playerLvl + "     Exp: " + Engine.currentPlayer.playerExp + "\n");
            Print();
            text = (" Exp to next level: " + Engine.currentPlayer.toNextLevel + "\n");
            Print();
        }

        public static void PlayerInventory()
        {
            text = ("  Potions: " + Engine.currentPlayer.potion + " Health: " + Engine.currentPlayer.health + "\n");
            Print();
        }

        public static void TitleCard()
        {
            text = ("The Dungeon");
            Print();

            Console.WriteLine();
        }

        public static void Naming()
        {
            
            text = ("What is the name of your Character?");
            Print();
            Console.WriteLine();
            Console.WriteLine();
            text = ("Name: ");
            Print();

            Engine.currentPlayer.name = (Console.ReadLine());

            Console.WriteLine();
            
        }

        public static void Awaken()
        {
            
            Console.Clear();
            text = (" 1) Wake Up!");

            Print();
            Console.WriteLine();
            Console.WriteLine();
            text = ("You awaken in a cold, dark room. You feel the touch of stone against your skin. Your eyes flutter open into the \ndarkness. As they struggle for purchase on your surroundings, small pricks of light start to appear in a line in \nthe distance. You stand, dazed and weak in the knees. As your legs regain their strength, a realization comes to you. \nYou remember nothing...  ");
            Print();
            Console.WriteLine();
            Console.WriteLine();

            if (Engine.currentPlayer.name == "") { text = ("...not even your name."); }
            else { text = ("...except your name, " + Engine.currentPlayer.name + "."); }
            Print();
            Console.ReadLine();
        }

        public static void CellInspect()
        {
            Console.Clear();
            text = ("Your eyes, now acclimated to the dark around you, and your strength and health \nreturning, you take a few solid steps towards the points of light, your hands \ngroping in front of you. Grasping out, you wrap your finger over a cold and \npitted metal bar, running vertically and continuing upwards beyond your reach.\n\nRunning your fingers along the surface. You touch a second horizontal bar, and \nfollow it to the left. About 6 inches away from the vertical bar is another. \nYour shoulder presses against the left wall and your hands grasp out and grab \nthe contiuous vertical poles. However, These bars jiggle and are able to move, \nbut are stuck in place.");
            Print();
        }


        


    }
}
