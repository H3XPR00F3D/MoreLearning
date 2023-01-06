using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Dungeon
{
    public class Player
    {
        public static int playerLvl = 1;
        public string name = "";
        public int coins = 0;
        public int  potion= 5;
        public int health = Player.playerLvl*12;
        public int damage;
        public int armorValue = Player.playerLvl*15;
        public int weaponValue = 1;
        public string playerWeapon="";
        public int playerExp = 0;
        public int toNextLevel = Player.playerLvl*100;

        
    }
    public class Engine
    {
        public static Player currentPlayer = new Player();
        internal static int playerLvl;
        public static int wait = Prompts.wait;
        public static string text;

        public static void Run()
        {
            Encounters encounters = new Encounters();
            string text = "";
            int wait = Prompts.wait;



            Start();
            Console.WriteLine();Console.WriteLine();
            Prompts.PromptPrint.Continue();
            

            /*
            Console.WriteLine();Console.WriteLine("Now lets try a random encounter.\nPress any key when ready");
            Console.ReadKey();
            encounters.RandomEncounter();
            */
            
        }
        public static void Start()
        {
            string text="";
            int wait =Prompts.wait;

            Prompts.EnginePrompts.TitleCard();

            Prompts.EnginePrompts.Naming();
            currentPlayer.name = (Console.ReadLine());
           // Prompts.EnginePrompts.Awaken();

           if (currentPlayer.name == "") { text = ("...not even your name."); }
            else { text=("...except your name, " + currentPlayer.name + "."); }
          

            Console.WriteLine(); Console.WriteLine();
            Prompts.PromptPrint.Continue();

           // Prompts.EnginePrompts.CellInspect();

            Console.WriteLine(); Console.WriteLine();
            Prompts.PromptPrint.Continue();

            Console.WriteLine(); Console.WriteLine();
          //  PlayerActions.EscapeCell();

            Console.WriteLine(); Console.WriteLine();
           // Encounters.FirstEncounter();

            Console.WriteLine(); Console.WriteLine();
            Rooms.DungeonHall();





        }
    }
}
