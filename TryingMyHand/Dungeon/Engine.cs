using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Dungeon
{
    class Player
    {
        public static int playerLvl = 1;
        public string name = "";
        public int coins = 0;
        public int  potion= 5;
        public int health = Player.playerLvl*12;
        public int damage=1;
        public int armorValue = Player.playerLvl*5;
        public int weaponValue = 2;
        public string playerWeapon="";
        public int playerExp = 0;
        public int toNextLevel = Player.playerLvl*100;

        
    }
    class Engine
    {
        public static Player currentPlayer = new();
        internal static int playerLvl=1;
        

        public static void Run()
        {
            Encounters encounters = new();




            Start();
            Console.WriteLine();Console.WriteLine();
            Prompts.PromptPrint.Continue();
            

            
            Console.WriteLine();Console.WriteLine("Now lets try a random encounter.\nPress any key when ready");
            Console.ReadKey();
            encounters.RandomEncounter();
            
            
        }
        public static void Start()
        {
            
            var r = new Rooms();

           /* 

             Prompts.EnginePrompts.TitleCard();
              Prompts.EnginePrompts.Naming();
              Prompts.EnginePrompts.Awaken();
                  

            Console.WriteLine(); Console.WriteLine();
            Prompts.PromptPrint.Continue();

            Prompts.EnginePrompts.CellInspect();

            Console.WriteLine(); Console.WriteLine();
            Prompts.PromptPrint.Continue();

            Console.WriteLine(); Console.WriteLine();
            PlayerActions.EscapeCell();

            Console.WriteLine(); Console.WriteLine();
           Encounters.FirstEncounter();

            */

            Console.WriteLine(); Console.WriteLine();
            r.DungeonHall();





        }
    }
}
