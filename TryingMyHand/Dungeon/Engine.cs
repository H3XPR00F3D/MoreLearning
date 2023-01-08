using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Dungeon
{ 
 public class Engine
    {
        public static Player currentPlayer { get; set; }
        public static int newGame = 0;
        
        public static void Run()
        {
            
            Encounters encounters = new();
            Enemies.SmallEnemyDict();
            Enemies.MidEnemyDict();
             Enemies.LargeEnemyDict();
             Start();
            Console.WriteLine(); Console.WriteLine();
            Prompts.Continue();

            Console.Clear();
            Console.WriteLine(); Console.WriteLine("Now lets try a random encounter.\nPress any key when ready");
            Console.ReadKey();
            encounters.RandomEncounter();

        }
        public static void Start()
        {
            Engine.newGame = 1;
           
           

            Prompts.TitleCard();
            Console.WriteLine();
           // LoadSave();
            if (Engine.newGame==1) { NewGame(); }


            Console.WriteLine(); Console.WriteLine();
            Rooms.DungeonHall();
        }

        public static void NewGame()
        {
            Console.Clear();
             //Prompts.Naming();
            //Prompts.Awaken();
            //Console.WriteLine(); Console.WriteLine();
            //Prompts.Continue();

            //Prompts.CellInspect();

            //Console.WriteLine(); Console.WriteLine();
            //Prompts.Continue();

            //Console.WriteLine(); Console.WriteLine();
            //Player.ActEscapeCell();

            Console.WriteLine(); Console.WriteLine();
            Encounters.FirstEncounter();
            Encounters.FirstEncounter();
            Encounters.FirstEncounter();
            Encounters.FirstEncounter();
        }
        public static void SaveGame(Player player)
        {
            string path = "Save.txt";

            // Create the file if it doesn't exist.
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            // Write the values of the Player class instance to the file.
            using (StreamWriter sw = File.AppendText(path))
            {
               

                sw.WriteLine(player.shieldValue);
                sw.WriteLine(player.toNextLevel);
                sw.WriteLine(player.playerExp);
                sw.WriteLine(player.playerWeapon);
                sw.WriteLine(player.weaponValue);
                sw.WriteLine(player.armorValue);
                sw.WriteLine(player.damage);
                sw.WriteLine(player.health);
                sw.WriteLine(player.potion);
                sw.WriteLine(player.coins);
                sw.WriteLine(player.name);
                sw.WriteLine(player.playerLvl);
            }
        }
        public static Player LoadGame()
        {
            
            string path = "Save.txt";
            Prompts.text = ("Our squires are reading your archives.... \n.....\n.....\n");
            Prompts.Print();
            // Return a new Player instance with default values if the file doesn't exist.
            if (!File.Exists(path))
            {
                Prompts.text = ("There is a problem with your archives. The scribes are in a tussle and demanding you be sent to the beginning. \nA new game will be started. \n");
                Prompts.Print();
                Prompts.Continue();
                NewGame();
                return new Player();
            }
            
            try
            {

                // Read the values from the file and create a new Player instance with those values.
                using (StreamReader sr = File.OpenText(path))
                {
                    int shieldValue = Convert.ToInt32(sr.ReadLine());
                    int toNextLevel = Convert.ToInt32(sr.ReadLine());
                    int playerExp = Convert.ToInt32(sr.ReadLine());
                    string playerWeapon = sr.ReadLine();
                    int weaponValue = Convert.ToInt32(sr.ReadLine());
                    int armorValue = Convert.ToInt32(sr.ReadLine());
                    int damage = Convert.ToInt32(sr.ReadLine());
                    int health = Convert.ToInt32(sr.ReadLine());
                    int potion = Convert.ToInt32(sr.ReadLine());
                    int coins = Convert.ToInt32(sr.ReadLine());
                    string name = sr.ReadLine();
                    int playerLvl = Convert.ToInt32(sr.ReadLine());

                    return new Player(shieldValue, toNextLevel, playerExp, playerWeapon, weaponValue, armorValue, damage, health, potion, coins, name, playerLvl);
                }
                Prompts.text = ("Your archives have been recovered");
                Prompts.Print();
            }
            catch (Exception)
            {
                Prompts.text=("There is a problem with your archives. The scribes are in a tussle and demanding you be sent to the beginning. \nA new game will be started. \n");
                Prompts.Print();
                Prompts.Continue();
                return new Player();
            }
        }
        public static void LoadSave()
        {
            Engine e = new();
            Prompts.text = ("Would you like to.... \nPlay a (N)ew Game\n(L)oad a Save\n");
            Prompts.Print();
            Console.WriteLine();
           Prompts.text=(": ");
            Prompts.Print();
            string input = Console.ReadLine();
            if (input.ToLower() == "n" || input.ToLower() == "new" || input.ToLower() == "new game")
            {
               Console.Clear();
               NewGame();
            }
            else if (input.ToLower() == "l" || input.ToLower() == "load" || input.ToLower() == "load a save" || input.ToLower() == "load save")
            {
                Console.Clear();
               Engine.currentPlayer = LoadGame();
            }
            
        }
    }
}
