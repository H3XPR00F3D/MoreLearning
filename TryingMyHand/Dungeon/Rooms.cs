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
        public string sizeDes = "";
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

        public static void ChestContents(string weapon, int coins, int potion)
        {
           string foundCoins = " and " + coins + " coins ";
            string foundPot= " and " + potion + "bottles of potion.";
            if (weapon > 0 && coins > 0 && potion > 0)
            {
                Prompts.text = (" You find a " + weapon + foundCoins + );
                Prompts.Print();
                Engine.currentPlayer.playerWeapon = weapon;
                Engine.currentPlayer.coins += coins;
                Engine.currentPlayer.potion += potion;
                Prompts.text = ("You equip the weapon and put the rest in storage.");
                Prompts.Print();

                Console.ReadLine();
            }
        }

        public void Chest()
        {
            //
            // Gives random weapon
            //
            Random rand = new Random();
            Rooms rooms = new Rooms();

            int index = rand.Next(Weapons.meleeWeapon.Count);
            string chestSize = rooms.sizeDes;
            string randomKey = Weapons.meleeWeapon.Keys.ElementAt(index);
            int appears = rand.Next(0, 1);
            int size = rand.Next(0, 2);
            

            if (appears == 0)
            {
                if (size == 0) { sizeDes = "Small"; }
                else if (size == 1) { sizeDes = "Medium"; }
                else if (size == 2) { sizeDes = "Large"; }

         
                
                (string name, int damage, int defense, string description, bool broken, int value) = Weapons.meleeWeapon[randomKey];
                Console.WriteLine();
                Prompts.text = ("You found a " + description + "\n");
                Prompts.Print();
                Prompts.text = ("Looking into the chest you see " + description + "\n");
                Prompts.Print();

                ChestContents(weapon,coins);

            }
            else if (appears == 1) { }
        }
    }
}
