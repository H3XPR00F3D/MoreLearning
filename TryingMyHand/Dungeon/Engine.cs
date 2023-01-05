using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Dungeon
{
    public class Player
    {

        public string name = "";
        public int coins = 0;
        public int  potion= 5;
        public int health = 10;
        public int damage;
        public int armorValue = 5;
        public int weaponValue = 1;
        public string playerWeapon="";

        
    }
    public class Engine : Prompts
    {
        public static Player currentPlayer = new Player();

        public static void Run()
        {
            Encounters encounters = new Encounters();
            Start();


            Console.WriteLine();Console.WriteLine();
            UserPrompts.Continue();

            encounters.FirstEncounter();
            Console.WriteLine();Console.WriteLine("Now lets try a random encounter.\nPress any key when ready");
            Console.ReadKey();
            encounters.RandomEncounter();

            
        }
        public static void Start()
        {
            string text;
            int wait =Prompts.wait;

            EnginePrompts.TitleCard();

            EnginePrompts.Naming();
            currentPlayer.name = Console.ReadLine();
            EnginePrompts.Awaken();
            Console.WriteLine();

            if (currentPlayer.name == "") { text = ("...not even your name."); }
            else { text=("...except your name, " + currentPlayer.name + "."); }
            PromptPrint.Print();

            Console.WriteLine(); Console.WriteLine();
            UserPrompts.Continue();
            EnginePrompts.CellInspect();

            Console.WriteLine(); Console.WriteLine();
            UserPrompts.Continue();

            PlayerActions.EscapeCell();


        }
    }
}
