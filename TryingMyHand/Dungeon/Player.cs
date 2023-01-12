using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
namespace MoreLearning.Dungeon
{
    public class Player
    {
        public int playerLvl { get; set; }
        public int shieldValue { get; set; }
        public int toNextLevel { get; set; }
        public int playerExp { get; set; }
        public string playerWeapon { get; set; }
        public int weaponValue { get; set; }
        public int armorValue { get; set; }
        public int damage { get; set; }
        public int health { get; set; }
        public int potion { get; set; }
        public int coins { get; set; }
        public string name { get; set; }
        public static int wait = Prompts.wait;
        public Player()
        {
            playerLvl = 1;
            shieldValue = 0;
            toNextLevel = 1;
            playerExp = 0;
            playerWeapon = "";
            weaponValue = 2;
            armorValue = 1;
            damage = 4;
            health = 13;
            potion = 5;
            coins = 0;
            name = "";
        }
        public static void ActEscapeCell()
        {
            Console.WriteLine();
            Console.Clear();
            Prompts.text = ("What action would you like to take?");
            Prompts.Print();
            int doorHealth = 5;
            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Prompts.PlayerLvlExp();
                Prompts.text = "**************************\n|  (J)iggle  (C)all out  |\n|        (S)houlder      |\n**************************\n";
                Prompts.Print();
                Prompts.PlayerInventory();
                Console.WriteLine();
                Console.WriteLine("        (L)eave");
                string input = Console.ReadLine();
                Console.WriteLine();
                if (input.ToLower() == "j" || input.ToLower() == "jiggle")
                {
                    doorHealth--;
                    Console.Clear();
                    Prompts.text = "You vigorously jiggle the bars.";
                    Prompts.Print();
                    if (doorHealth < 5 && doorHealth > 0)
                    {
                        Console.WriteLine();
                        Prompts.text = "You can feel the bars give a little. Maybe shake it some more.";
                        Prompts.Print();
                        if (Engine.currentPlayer.playerLvl == 1) { Encounters.GainXP(1); }
                        else Encounters.GainXP(2);
                    }
                }
                else if (input.ToLower() == "c" || input.ToLower() == "call out")
                {
                    Console.Clear();
                    Console.WriteLine(); Prompts.text = "You call out down the hall, but all you hear is your own voice echoing off the walls."; Prompts.Print();
                    if (doorHealth <= 5)
                    {
                        Console.WriteLine();
                        Prompts.text = "Letting your captors know you are awake does not give you any solace. You should try something else.";
                        Prompts.Print();
                    }
                }
                else if (input.ToLower() == "s" || input.ToLower() == "shoulder")
                {
                    doorHealth -= 2;
                    Console.Clear();
                    Console.WriteLine(); Prompts.text = "You take a few steps back, dip your strong shoulder and charge...."; Prompts.Print();
                    if (doorHealth > 0 && doorHealth < 5)
                    {
                        Console.WriteLine();
                        Prompts.text = "That did something. The barred area has shaken and is very much looser. A few more of those should do the trick.";
                        Prompts.Print();
                        Encounters.GainXP((Engine.currentPlayer.playerExp * 2) - 1);
                        if (Engine.currentPlayer.playerExp < 1) { Engine.currentPlayer.playerExp = 1; }
                    }
                }
                else if (input.ToLower() == "l" || input.ToLower() == "leave")
                {
                    Console.WriteLine(); Prompts.text = "You let go of the bars and step back, looking into the small, dark room. It is very tiny, only enough room to take a few steps, or lay against the wall."; Prompts.Print();
                    if (doorHealth > 0 && doorHealth <= 5) { Console.WriteLine(); Prompts.text = "You might want to try the bars again. There isn't much else going on."; Prompts.Print(); }
                }
            }
            while (doorHealth > 0);
            if (doorHealth <= 0)
            {
                Console.WriteLine();
                Console.WriteLine();
                Prompts.text = "The bars crash outward towards the ground. The metal slams against the stone floor and the sound fills the long hall.\n";
                Prompts.Print();
                Encounters.GainXP(5);
                Console.WriteLine();
                Console.WriteLine();
                Prompts.text = ("You are now free. However, there is a scuffling sound, and you see a........");
                Prompts.Print();
            }
        }
        public static void Death()
        {
            Engine e = new();
            Prompts.text = ("YOU HAVE BEEN SLAIN.\nWould you like to (S)ave your progress\n(R)eturn to the Title Screen");
            Prompts.Print();
            string input = Console.ReadLine();
            if (input.ToLower() == "s" || input.ToLower() == "save")
            {
                Engine.SaveGame(Engine.currentPlayer);
            }
            else if (input.ToLower() == "r" || input.ToLower() == "return")
            {
                Engine.newGame = 1;
                // Engine.Run();
            }
        }
        public Player(int shieldValue, int toNextLevel, int playerEXP, string playerWeapon, int weaponValue, int armorValue, int damage, int health, int potion, int coins, string name, int playerLvl)
        {
            this.playerLvl = playerLvl;
            this.shieldValue = shieldValue;
            this.toNextLevel = toNextLevel;
            this.playerExp = playerExp;
            this.playerWeapon = playerWeapon;
            this.weaponValue = weaponValue;
            this.armorValue = armorValue;
            this.damage = damage;
            this.health = health;
            this.potion = potion;
            this.coins = coins;
            this.name = name;
        }
    }
}