using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Dungeon
{
    internal class Chest
    {
        //public string sizeDes = "";

        //Randomly determines in a chest is in the room or not. 
        //if a chest is present it will then pull a weapon from the 
        //Weapons class dictionaries and pass the values to ChestContents
        //also determine the amount of coin and potions chest could contain
        public static void CheckChest()
        {
            //
            // Gives random weapon
            //
            Random rand = new Random();
            Rooms rooms = new Rooms();

            int index = rand.Next(Weapons.meleeWeapon.Count);
            string randomKey = Weapons.meleeWeapon.Keys.ElementAt(index);
            int appears = rand.Next(0, 3);
            int maxCoins = (Engine.currentPlayer.playerLvl * 5);
            int size = rand.Next(0, 2);
            int potion = rand.Next(1, 5);
            int coins = rand.Next(0, maxCoins);

            if (appears == 0)
            {
                Prompts.text = ("There is a chest in the corner\n");
                Prompts.Print();
                (string name, int damage, int defense, string description, bool broken, int value) = Weapons.meleeWeapon[randomKey];
                string weapon = name;
                Console.WriteLine();
                ChestContents(size, weapon, coins, potion);
            }
            else if (appears == 1) { }
        }

        //Fills the contents of the chest once a detemination on whether the chest loads or not.  
        //Once a determination is made it pulls random values from CheckChest
        //CheckChest tells this method whether the chest is small medium or large,.
        //if small it will randomly fill with either a weapon, coins or potions
        //if med it will randomy fill the chest with either a weapon and coins, weapon and potions, or potions and coins.
        //if large it will be filled with all 3 options.
        //it tells the player what is in the chest then places the contents in their inventory and equips the weapon if their is one.
        public static void ChestContents(int size, string weapon, int coins, int potion)
        {
            Random rand = new();

            string foundCoins = coins + " coins";
            string foundPot = potion + " bottles of potion";
            if (size == 0)
            {
                int whatsInTheBox = rand.Next(0, 2);

                if (whatsInTheBox == 0) { Prompts.text = ("You have found a " + weapon); Prompts.Print(); Engine.currentPlayer.playerWeapon = weapon; }
                else if (whatsInTheBox == 1) { Prompts.text = (" You have found " + foundCoins + "."); Prompts.Print(); Engine.currentPlayer.coins += coins; }
                else if (whatsInTheBox == 2) { Prompts.text = ("You have found " + foundPot + "."); Prompts.Print(); Engine.currentPlayer.potion += potion; }
                Prompts.text = ("\n\nYou equip the weapon and put the rest in storage.\n");
                Prompts.Print();
                Console.ReadLine();
            }
            else if (size == 1)
            {
                int whatsInTheBox = rand.Next(0, 2);

                if (whatsInTheBox == 0) { Prompts.text = ("You have found a " + weapon + " and " + foundCoins + "."); Prompts.Print(); Engine.currentPlayer.playerWeapon = weapon; Engine.currentPlayer.coins += coins; }
                else if (whatsInTheBox == 1) { Prompts.text = ("You have found a " + weapon + " and " + foundPot + "."); Prompts.Print(); Engine.currentPlayer.playerWeapon = weapon; Engine.currentPlayer.potion += potion; }
                else if (whatsInTheBox == 2) { Prompts.text = (" You have found " + foundCoins + " and " + foundPot + "."); Prompts.Print(); Engine.currentPlayer.coins += coins; }
                Prompts.text = ("\n\nYou equip the weapon and put the rest in storage.\n");
                Prompts.Print();
                Console.ReadLine();
            }
            else if (size == 2)
            { 
                Prompts.text = ("You have found a " + weapon + ", " + foundCoins + ", and " + foundPot); 
                Prompts.Print(); 
                Engine.currentPlayer.playerWeapon = weapon;
                Engine.currentPlayer.coins += coins; 
                Engine.currentPlayer.potion += potion; 
                Console.ReadLine(); 
            }
        }
    }
}
