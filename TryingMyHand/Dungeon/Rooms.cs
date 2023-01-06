using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Dungeon
{
    public class Rooms
    {

        public static void DungeonHall()
        {
            string text = "";
            int wait = Prompts.wait;


            text =("You are staring down a short, dark hallway. The floor and walls are made of cold stone and candle sconces line the walls.\n There are doors along the walls and one at the far end of the hallway.");
            Prompts.PromptPrint.Print();

            Console.WriteLine();
            Console.WriteLine();
            Prompts.PlayerRecords.PlayerLvlExp();
            text = ("**************************\n| Search Rooms to (L)eft |\n| Search Room to (R)ight |\n| Head to (D)oor in back |\n**************************\n  Potions: " + Engine.currentPlayer.potion + " Health: " + Engine.currentPlayer.health);
            Prompts.PromptPrint.Print();
            Prompts.PlayerRecords.PlayerInventory();
            Console.WriteLine();
    
            string input = Console.ReadLine();
            Console.WriteLine();

        }





    }
}