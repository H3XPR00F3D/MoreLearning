using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Dungeon
{
    public class EnginePrompts
    {
        public static Player currentPlayer = new();
        public static void TitleCard()
        {
            PromptPrint.text = ("The Dungeon");
            PromptPrint.Print();

            Console.WriteLine();
        }

        public static void Naming()
        {
            PromptPrint.text = ("What is the name of your Character?");
            PromptPrint.Print();
            Console.WriteLine();
            PromptPrint.text = ("Name: ");
            PromptPrint.Print();

            currentPlayer.name = (Console.ReadLine());

            Console.WriteLine();
        }

        public static void Awaken()
        {
            Console.Clear();
            PromptPrint.text = (" 1) Wake Up!");

            PromptPrint.Print();
            Console.WriteLine();
            Console.WriteLine();
            PromptPrint.text = ("You awaken in a cold, dark room. You feel the touch of stone against your skin. Your eyes flutter open into the \ndarkness. As they struggle for purchase on your surroundings, small pricks of light start to appear in a line in \nthe distance. You stand, dazed and weak in the knees. As your legs regain their strength, a realization comes to you. \nYou remember nothing...  ");
            PromptPrint.Print();
            Console.WriteLine();
            Console.WriteLine();

            if (currentPlayer.name == "") { PromptPrint.text = ("...not even your name."); }
            else { PromptPrint.text = ("...except your name, " + currentPlayer.name + "."); }
            PromptPrint.Print();
        }

        public static void CellInspect()
        {
            Console.Clear();
            PromptPrint.text = ("Your eyes, now acclimated to the dark around you, and your strength and health returning, you take a few solid steps towards the points of light, your hands groping in front of you. Grasping out, you wrap your finger over a cold and pitted metal bar, running vertically and continuing upwards beyond your reach.\n\nRunning your fingers along the bar you touch a second horizontal bar, and follow it to the left. About 6 inches away from the vertical bar is another. Your shoulder presses against the left wall and your hands grasp out and grab the contiuous vertical poles. However, These bars jiggle and are able to move, but are stuck in place.");
            PromptPrint.Print();
        }
    }
}
