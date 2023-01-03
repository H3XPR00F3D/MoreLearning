using System;

namespace MoreLearning.Dungeon
{

    class Encounters
    {
        static Random rand = new Random();
        public static void FirstEncounter()
        {
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (h > 0)
            {
                Console.WriteLine("**************************");
                Console.WriteLine("|   (A)ttack  (D)efend   |");
                Console.WriteLine("|     (R)un    (H)eal    |");
                Console.WriteLine("**************************");
                Console.WriteLine(" Potions: " + Engine.currentPlayer.potion + " Health: " + Engine.currentPlayer.health);
                string input = Console.ReadLine();

                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    ///////////////////////////
                    //////////ATTACK//////////
                    ///////////////////////////
                    
                    Console.WriteLine("With your FISTS you attack the " +n+ "The MONSTER swipes back.");
                    int damage = p-Engine.currentPlayer.armorValue;
                    if (damage < 0){ damage = 0; }
                    int attack = rand.Next(0, Engine.currentPlayer.weaponValue) + rand.Next(1,4);
                    Console.WriteLine("You lose " +damage+ "health and deal " +attack+ " damage.");
                    Engine.currentPlayer.health -= damage;
                    h -= attack;

                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    ///////////////////////////
                    //////////DEFEND/////////
                    //////////////////////////
                    
                    Console.WriteLine("As the " + n + " prepares it's attack, you ready yourself to block it.");
                    int damage = (p/4) - Engine.currentPlayer.armorValue;
                    int attack = rand.Next(0, Engine.currentPlayer.weaponValue) + rand.Next(1, 4);
                    Console.WriteLine("You lose " + damage + "health and deal " + attack + " damage.");
                    Engine.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    ////////////////////////////
                    ///////////RUN////////////
                    //////////////////////////
                    Console.WriteLine(" ");
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    ///////////////////////////
                    ///////////HEAL///////////
                    ///////////////////////////
                    Console.WriteLine(" ");
                }

                Console.ReadKey();

            }
        }
    }
}
