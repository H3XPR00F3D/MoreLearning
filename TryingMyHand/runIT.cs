using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning
{
   public class runIT
    {

        public static void Main()
        {


           int choice;
           Console.WriteLine("What would you like to try out? Please pick a number.");
            Console.WriteLine();

            SelectionLists s = new SelectionLists();
            s.Apps();

            Console.WriteLine();
            choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                GuessingGame g = new GuessingGame();
                g.Game();
            }
           else if (choice == 2)
            {
                NetworkPing n  = new NetworkPing();
                n.Pinging();
            }
            else if (choice == 3)
            {
                Fibo f = new Fibo();
                f.Sequence();
            }
            else
            {
                Console.WriteLine("Please make a new selection");
            }

            //Exit Prompt.
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
