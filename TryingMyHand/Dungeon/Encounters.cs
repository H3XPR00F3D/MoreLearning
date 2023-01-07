using System;
namespace MoreLearning.Dungeon
{

    class Encounters:Enemies
    {
        static Random rand = new Random();


        public static void FirstEncounter()
        {

            Console.Clear();

            Console.WriteLine("Here comes a Human Rogue");
            Console.WriteLine();
            Combat(false, "Human Rogue", 1, 5, "Rusty Dagger");
        
        }
        public void RandomEncounter()
        {

            // Get a random key from the dictionary
            Random random = new Random();
            int index = random.Next(Enemies.enemiesMid.Count);
            string randomKey = Enemies.enemiesMid.Keys.ElementAt(index);

            // Get the values for the random enemy

            Console.WriteLine(Enemies.enemiesMid.Count);
            (string name, int power, int health, string weapon) = Enemies.enemiesMid[randomKey];

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("You are being accosted by a " + name + ". It has " +health+" health, and " +power+ " power and is weilding "+weapon);
            Console.WriteLine();

            // Call the Combat method with the values
            Combat(false, name, power, health, weapon);
        }
      
        public static void Combat(bool random, string name, int power, int health, string weapon)
        {
            string n = "";
            int p = 0;
            int h = 0;
            string w = "";
            if (random)
            {

            }
            else
            {
                w = weapon;
                n = name;
                p = power;
                h = health;
            }
            while (h > 0)
            {
                
                Console.WriteLine(n);
                Console.WriteLine("Atk: " + p + " HP: " +h );
                Console.WriteLine("**************************");
                Console.WriteLine("|   (A)ttack  (D)efend   |");
                Console.WriteLine("|     (R)un    (H)eal    |");
                Console.WriteLine("**************************");
                Console.WriteLine("  Potions: " + Engine.currentPlayer.potion + " Health: " + Engine.currentPlayer.health);
                Console.WriteLine();
                string input = Console.ReadLine();
                Console.WriteLine();

                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    ///////////////////////////
                    //////////ATTACK//////////
                    ///////////////////////////
                    Console.Clear();
                    Console.WriteLine("With your FISTS you attack the " +n+ " , and it swings back at you with it's "+w+".");
                    Console.WriteLine();
                    int damage = (p/2)-Engine.currentPlayer.armorValue;
                    if (damage < 0){ damage = 0; }
                    int attack = rand.Next(0, Engine.currentPlayer.weaponValue) + rand.Next(1,4);
                    Console.WriteLine("You lose " +damage+ " health and deal " +attack+ " damage.");
                    Engine.currentPlayer.health -= damage;
                    h -= attack;

                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    ///////////////////////////
                    //////////DEFEND/////////
                    //////////////////////////
                    Console.Clear();
                    Console.WriteLine("As the " + n + " strikes out with it's " +w+". You ready yourself to block it.");
                    int damage = p - Engine.currentPlayer.armorValue;
                    if (damage < 0) { damage = 0; }
                    int attack = rand.Next(0, Engine.currentPlayer.weaponValue) + rand.Next(1, 4);
                    Console.WriteLine();
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage.");
                    Engine.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    ////////////////////////////
                    ///////////RUN/////////////
                    ////////////////////////////
                    Console.Clear();
                    Console.WriteLine("You try to run. ");
                   if( rand.Next(0,2) == 0)
                    {
                        Console.WriteLine("As you sprint away from the  " + n + ", it's strike cateches you in the back.");
                        double damage = p-.5 - Engine.currentPlayer.armorValue;
                        if (damage < 0) { damage=0; }   
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
                    if (Engine.currentPlayer.potion==0)
                    {
                        Console.WriteLine("You fumble in your bag, searching for the weight of a full bottle of potion, but all you find are empties. ");
                        Console.WriteLine("The "+n+ "");
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
        }
    }
}
