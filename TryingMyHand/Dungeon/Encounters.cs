using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace MoreLearning.Dungeon
{
    class Encounters:Enemies
    {
        static Random rand = new Random();
        public Player Player { get; set; }
        //public static Player? currentPlayer= new();
        public Encounters(Player player)
        {
            this.Player = player;
            // Assume that player is a valid Player object
            Engine.SetCurrentPlayer(player);
        }
        public void FirstEncounter()
        {
            Console.WriteLine("............ the Dungeon Guard!!");
            Images.HumanBrute();
            Combat(false, "Human Brute", 1, 5, "Wooden Club", 20);
        }
        public static void RandomEncounter()
        {  
            int levelRange = Engine.currentPlayer.playerLvl;
            if (levelRange < 10) { RandomEncounterSmall(); }
            else if (levelRange >=10 && levelRange < 20) { RandomEncounterMid(); }
            else if (levelRange >= 20) { RandomEncounterLarge(); }
        }
        public static void RandomEncounterSmall()
        {
            // Get a random key from the dictionary
            Random random = new Random();
            int index = random.Next(Enemies.enemiesSmall.Count);
            string randomKey = Enemies.enemiesSmall.Keys.ElementAt(index);
            // Get the values for the random enemy
           // Console.WriteLine(Enemies.enemiesSmall.Count);
            (string name, int power, int health, string weapon, int xp) = Enemies.enemiesSmall[randomKey];
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("You are being accosted by a " + name + ". It has " + health + " health, and " + power + " power and is weilding " + weapon);
            Console.WriteLine();
            // Call the Combat method with the values
            Combat(false, name, power, health, weapon,xp);
        }
        public static void RandomEncounterMid()
        {
            // Get a random key from the dictionary
            Random random = new Random();
            int index = random.Next(Enemies.enemiesMid.Count);
            string randomKey = Enemies.enemiesMid.Keys.ElementAt(index);
            // Get the values for the random enemy
          //  Console.WriteLine(Enemies.enemiesMid.Count);
            (string name, int power, int health, string weapon, int xp) = Enemies.enemiesMid[randomKey];
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("You are being accosted by a " + name + ". It has " + health + " health, and " + power + " power and is weilding " + weapon);
            Console.WriteLine();
            // Call the Combat method with the values
            Combat(false, name, power, health, weapon,xp);
        }
        public static void RandomEncounterLarge()
        {
            // Get a random key from the dictionary
            Random random = new Random();
            int index = random.Next(Enemies.enemiesLarge.Count);
            string randomKey = Enemies.enemiesLarge.Keys.ElementAt(index);
            // Get the values for the random enemy
            //Console.WriteLine(Enemies.enemiesLarge.Count);
            (string name, int power, int health, string weapon, int xp) = Enemies.enemiesLarge[randomKey];
            Console.Clear();
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("You are being accosted by a " + name + ". It has " + health + " health, and " + power + " power and is weilding " + weapon);
            Console.WriteLine();
            // Call the Combat method with the values
            Combat(false, name, power, health, weapon,xp);
        }
        public static void Combat(bool random, string name, int power, int health, string weapon, int xp)
        {
            string n = "";
            int p = 0;
            int h = 0;
            string w = "";
            int xpTemp = 0;
                w = weapon;
                n = name;
            p = power;
               // p = (power*rand.Next(1,3)/2) ;
                h = health;
                xpTemp = xp;
            do
            {
                Console.WriteLine(n);
                Prompts.PlayerLvlExp();
                Prompts.text = ("Atk: " + p + " HP: " + h + "\n" + "************************** \n|   (A)ttack  (D)efend   |\n|     (R)un    (H)eal    |\n**************************\n");
                Prompts.Print();
                Prompts.PlayerInventory();
                Console.WriteLine();
                string input = Console.ReadLine();
                Console.WriteLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    ///////////////////////////
                    //////////ATTACK//////////
                    ///////////////////////////
                    Console.WriteLine("With your FISTS you attack the " + n + " , and it swings back at you with it's " + w + ".");
                    Console.WriteLine();
                    int damage = p  - Engine.currentPlayer.armorValue;
                    if (damage < 0) { damage = 0; }
                    int attack = rand.Next(0, Engine.currentPlayer.weaponValue) + rand.Next(0, 20);
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage.");
                    Engine.currentPlayer.health -= damage;
                    h -= attack;
                    if (h < 0) { h = 0; }
                    if (Engine.currentPlayer.health <= 0) {Player.Death(); }
                    if (h <= 0) { GainXP(xpTemp); } 
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    ///////////////////////////
                    //////////DEFEND/////////
                    //////////////////////////
                    Console.Clear();
                    Console.WriteLine("As the " + n + " strikes out with it's " + w + ". You ready yourself to block it.");
                    int damage = (p / 2) - Engine.currentPlayer.armorValue;
                    if (damage < 0) { damage = 0; }
                    int attack = rand.Next(0, Engine.currentPlayer.weaponValue) + rand.Next(1, 10);
                    Console.WriteLine();
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage.");
                    Console.WriteLine("You lose " + (damage -Engine.currentPlayer.shieldValue) + " health and deal " + attack + " damage.");
                    Engine.currentPlayer.health -= damage;
                    h -= attack;
                    if (h < 0) { h = 0; }
                    if (    Engine.currentPlayer.health <= 0) { Player.Death(); }
                    if (h <= 0) { GainXP(xpTemp); }
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    ////////////////////////////
                    ///////////RUN/////////////
                    ////////////////////////////
                    Console.Clear();
                    Console.WriteLine("You try to run. ");
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("As you sprint away from the  " + n + ", it's strike cateches you in the back.");
                        double damage = p - .5 - Engine.currentPlayer.armorValue;
                        if (damage < 0) { damage = 0; }
                        Console.WriteLine("You lose " + damage + " health and are unable to escape.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You turn and run, catching the " + n + " off guard. As it stands in confusion, you make your escape.");
                        Console.ReadKey();
                        //go to store
                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    ///////////////////////////
                    ///////////HEAL///////////
                    ///////////////////////////
                    Console.Clear();
                    Console.WriteLine(" ");
                    if (Engine.currentPlayer.potion == 0)
                    {
                        Console.WriteLine("You fumble in your bag, searching for the weight of a full bottle of potion, but all you find are empties. ");
                        Console.WriteLine("The " + n + "");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You pull out a glowing green flask and drink from it deeply. ");
                        int potionV = 5;
                        Console.WriteLine("You recover " + potionV + " health");
                        Engine.currentPlayer.health += potionV;
                        Console.ReadKey();
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            while (h > 0);
        }
        public static void GainXP(int xp)
        {
            int pL = Engine.currentPlayer.playerLvl;
            string pN = Engine.currentPlayer.name;
            int pNL = Engine.currentPlayer.toNextLevel;
            int x = xp;
            int nXP;
            int pXP = Engine.currentPlayer.playerExp;
            if (x < 1) { x = 1; }
            if (pXP< 1) { pXP = 1; }
            Console.WriteLine();
            Prompts.text = (pN + " has gained " + x + " exp.");
            Prompts.Print();
            Console.WriteLine();
            pXP += x;
            //Level up 
            while (pXP >= pNL)
            {
                pL++;
                Engine.currentPlayer.playerLvl=pL;
                pNL = (int)Math.Pow((pL*1),4);
                Engine.currentPlayer.toNextLevel = pNL;
                Engine.currentPlayer.health = pL*13;
                Engine.currentPlayer.damage = pL * 4;
                Engine.currentPlayer.armorValue = pL+1;
                Prompts.text = (pN + " has gained a new level. They are now lvl: " + pL + " and must now gain " + pNL + " exp to level up again\n");
                Prompts.Print();
                Prompts.Continue();
            }
            Engine.currentPlayer.playerExp += xp;
        }
    }
}