using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace MoreLearning.Dungeon
{
    internal class Rooms
    {
        int wait = Prompts.wait;
        
        public static void DungeonHall()
        {
            Prompts.text = ("You are staring down a short, dark hallway. The floor and walls are made of cold stone and candle sconces line the walls.\n There are doors along the walls and one at the far end of the hallway.");
            Prompts.Print();
            Console.WriteLine();
            Console.WriteLine();
            Prompts.PlayerLvlExp();
            Prompts.text = ("**************************\n| Search Rooms to (L)eft |\n| Search Room to (R)ight |\n| Head to (D)oor in back |\n**************************\n ");
            Prompts.Print();
            Prompts.PlayerInventory();
            Console.WriteLine();
            string input = Console.ReadLine();
            Console.WriteLine();
        }


    }
}
