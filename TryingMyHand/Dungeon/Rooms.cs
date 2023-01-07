using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Dungeon
{
    internal class Rooms
    {
        int wait = PromptPrint.wait;
        public static void DungeonHall()
        {
            PromptPrint.text = ("You are staring down a short, dark hallway. The floor and walls are made of cold stone and candle sconces line the walls.\n There are doors along the walls and one at the far end of the hallway.");
            PromptPrint.Print();

            Console.WriteLine();
            Console.WriteLine();
            PlayerRecords.PlayerLvlExp();
            PromptPrint.text = ("**************************\n| Search Rooms to (L)eft |\n| Search Room to (R)ight |\n| Head to (D)oor in back |\n**************************\n ");
            PromptPrint.Print();
            PlayerRecords.PlayerInventory();
            Console.WriteLine();

            string input = Console.ReadLine();
            Console.WriteLine();
        }
    }
}