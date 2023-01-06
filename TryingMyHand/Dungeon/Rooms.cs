using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Dungeon
{

    public class Rooms
    {
        public static int wait = Prompts.wait;
        public static string text = Prompts.text;

        public void DungeonHall()
        {

            Console.Clear();
            //Console.WriteLine("You are staring down a short, dark hallway. The floor and walls are made of cold stone and candle sconces line the \nwalls. There are doors along the walls and one at the far end of the hallway.");
            text =("You are staring down a short, dark hallway. The floor and walls are made of cold stone and candle sconces line the \nwalls. There are doors along the walls and one at the far end of the hallway.");
            // Prompts.PromptPrint.Print();

            Console.WriteLine();
            Console.WriteLine();
            Prompts.PlayerRecords.PlayerLvlExp();
            Console.WriteLine("**************************\n| Search Room to (L)eft  |\n| Search Room to (R)ight |\n| Head to (D)oor in back |\n**************************");
           Prompts.PromptPrint.Print();
            Prompts.PlayerRecords.PlayerInventory();
            Console.WriteLine();
    
            string input = Console.ReadLine();
            Console.WriteLine();

        }





    }
}