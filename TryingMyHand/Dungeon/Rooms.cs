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

        public static void DungeonHall(int visiting)
        {
            Prompts.text = ("You are staring down a short, dark hallway. The floor and walls are made of cold stone and candle sconces line the walls. \nThere is a door on each side of the walls and one at the far end of the hallway.");
            Prompts.Print();
            Console.WriteLine();
            Console.WriteLine();
            Prompts.Continue();

            visiting = 1;

            do
            {
                Console.Clear();
                Prompts.PlayerLvlExp();
                Prompts.text = ("**************************\n| Search Room to (L)eft |\n| Search Room to (R)ight |\n| Head to (D)oor in back |\n**************************\n ");
                Prompts.Print();
                Prompts.PlayerInventory();
                Console.WriteLine();
                string input = Console.ReadLine();
                Console.WriteLine();
                if (input.ToLower() == "l" || input.ToLower() == "left")
                {
                    Prompts.text = ("The door is barred like yours was. It's occupent is dressed as you are and curled in the corner. The are not moving or making \nany sounds. It is unlikely they are still alive.\n\n");
                    Prompts.Print();
                    Prompts.Continue();
                }
                if (input.ToLower() == "r" || input.ToLower() == "right")
                {
                    Prompts.text = ("The room to the right is empty. There are dark spots on the floor and walls. It seems to have been empty for a long time.\n");
                    Prompts.Print();
                    Prompts.Continue();
                }
                if(input.ToLower() == "d" || input.ToLower() == "door")
                {
                    Prompts.text = ("You take out the key you got from the jailer and push it into the lock. It turns slowly as it grinds against the iron of the lock, \nsqueeling until a loud CLUNK releases the lock and lets the door swing open.\n\n");
                    Prompts.Print();
                    visiting = 0;
                    Prompts.Continue();
                }
            }
            while (visiting == 1);
        }
        /*
        When a random room is needed, will build a room with a random number of doors, furniture, 
        a chest or not, an enemy or not, also counts how many random 
        rooms have been visited before.
        */
        public void RandomRoom(int roomType, int doorAmt, int furnitureNum, int hasChest, int hasEnemy)
        {
            Chest chest = new();
            Random rand = new();
            chest.CheckChest();
            int size = chest.size;
            int potions = chest.potion;
            int coins = chest.coins;
            string weapon = chest.weapon;
            int appears = chest.appears;
            roomType = 0;
            if(roomType== 0)
             {
                doorAmt = rand.Next(0, 3);
                furnitureNum = 0;
                hasChest = rand.Next(0,1);
                hasEnemy = rand.Next(0, 1);
            }


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
                RoomDescription(doorAmt, hasChest, furnitureNum);
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

        //RoomType dict. contains name, name, number of doors, has an enemy, has a chest, furniture included)
        public static Dictionary<string, (string, int, int, int, int)> RoomType;
        public static void RoomTyping()
        {
            Random random= new Random();
           int randDoor = random.Next(2,6);

            RoomType = new Dictionary<string, (string, int, int, int, int)>();

            RoomType.Add("Hallway", ("Hallway", randDoor, 0, 0, 0));
            RoomType.Add("Bedchambers", ("Bedchambers", 0, 0, 0,0));
            RoomType.Add("Drawing Room", ("Drawing Room", 0, 0, 0, 0));
            RoomType.Add("Banquet Hall", ("Banquet Hall", 0, 0, 0, 0));
            RoomType.Add("Armory", ("Armory", 0, 0, 0, 0));
            RoomType.Add("Study", ("Study", 0, 0, 0, 0));
            RoomType.Add("Kitchen", ("Kitchen", 0, 0, 0, 0));
            RoomType.Add("Throne Room", ("Throne Room", 0, 0, 0, 0));
            RoomType.Add("Great Hall", ("Great Hall", 0, 0, 0, 0));
            RoomType.Add("Solarium", ("Solarium", 0, 0, 0, 0));
            RoomType.Add("Chapel", ("Chapel", 0, 0, 0, 0));
            RoomType.Add("Ball Room", ("Ball Room", 0, 0, 0, 0));
            RoomType.Add("Dining Room", ("Dining Room", 0, 0, 0, 0));
        }
    }
}
