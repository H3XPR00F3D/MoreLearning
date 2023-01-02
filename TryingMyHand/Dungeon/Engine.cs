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
        public string potion;
        public int health;
        public var weaponChoice;
        
    }
    public class Engine : Prompts
    {
        public static Player currentPlayer = new Player();

        public static void Start()
        {
            string text;
            int wait = 2;

            EnginePrompts.TitleCard();

            EnginePrompts.Naming();
            currentPlayer.name = Console.ReadLine();
            EnginePrompts.Awaken();
            Console.WriteLine();

            if (currentPlayer.name == "") { text = ("...not even your name."); }
            else { text=("...except your name, " + currentPlayer.name + "."); }

            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(wait);
            }

            Console.WriteLine();
            Console.WriteLine();
            UserPrompts.Continue();
            EnginePrompts.CellInspect();

            Console.WriteLine();
            Console.WriteLine();
            UserPrompts.Continue();
        }

    }

}
