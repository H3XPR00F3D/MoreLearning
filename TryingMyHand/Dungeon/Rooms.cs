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
        /*
        When a random room is needed, will build a room with a random number of doors, furniture, 
        a chest or not, an enemy or not, also counts how many random 
        rooms have been visited before.
        */
        public void RandomRoom()
        {
            Chest chest = new();
            Random rand = new();

            int doorNum = rand.Next(0,4);
            int furnitureNum = 0;
            int hasChest = 0;
            int hasEnemy = rand.Next(0,1);
            chest.CheckChest();
            int size = chest.size;
            int potions = chest.potion;
            int coins = chest.coins;
            string weapon = chest.weapon;
            int appears = chest.appears;

            Prompts.text = ("It's dark inside, lit by candels. There are no windows.\n");
            Prompts.Print();

            if (hasEnemy == 0)
            {
                Prompts.text = " As you gain your barings, you are attacked!!";
                Prompts.Print();
                Encounters.RandomEncounter();
                GenerateDoors();
               
                if (appears == 0)
                {
                    Chest.ChestContents(chest.size, chest.weapon, chest.coins, chest.potion);
                }
                RoomDescription(doorNum, hasChest, furnitureNum);
            }
            else if (hasEnemy == 1)
            {

            }


            GenerateDoors();

        }

        public void GenerateDoors()
        {

        }
        public void RoomDescription(int doors, int chest, int furniture )
        {
            int d = doors;
            int c = chest;
            int f = furniture;

        }
    }
}
