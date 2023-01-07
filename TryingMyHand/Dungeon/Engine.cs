using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Dungeon
{
  
    public class Engine
    {
        public static Player currentPlayer = new();
        internal static int playerLvl=1;
        
        public static void Run()
        {
            Encounters encounters = new();
            Enemies.SmallEnemyDict();
            Enemies.MidEnemyDict();
            Enemies.LargeEnemyDict();

           Start();
            Console.WriteLine();Console.WriteLine();
            PromptPrint.Continue();

            Console.WriteLine();Console.WriteLine("Now lets try a random encounter.\nPress any key when ready");
            Console.ReadKey();
            encounters.RandomEncounter();
        }
        public static void Start()
        {
            EnginePrompts.TitleCard();
            EnginePrompts.Naming();
            EnginePrompts.Awaken();

            Console.WriteLine(); Console.WriteLine();
            PromptPrint.Continue();
      
            EnginePrompts.CellInspect();

            Console.WriteLine(); Console.WriteLine();
           PromptPrint.Continue();

            Console.WriteLine(); Console.WriteLine();
            PlayerActions.EscapeCell();

            Console.WriteLine(); Console.WriteLine();
            Encounters.FirstEncounter();

            Console.WriteLine(); Console.WriteLine();
            Rooms.DungeonHall();
        }
    }
}
