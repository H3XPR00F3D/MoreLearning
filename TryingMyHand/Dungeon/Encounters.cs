using System;

namespace MoreLearning.Dungeon
{
    public class Encounters
    {
        Invento
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
                    //attack
                    Console.WriteLine(" ");
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //defend
                    Console.WriteLine(" ");
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //run
                    Console.WriteLine(" ");
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //heal
                    Console.WriteLine(" ");
                }

            }
        }
    }
}
