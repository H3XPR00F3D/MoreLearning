using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning
{
   public class runIT
    {
        
        public static void Main()
        {
            bool reload = true;
            while (reload == true)
            {
                Run();
            }
        }

        public static void Run()
        {
            int choice = 0;


            while (choice == 0)
            {
                Console.WriteLine("What would you like to try out? Please pick a number.");
                Console.WriteLine();

                SelectionLists s = new SelectionLists();
                s.Apps();

                Console.WriteLine();
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    GuessingGame g = new GuessingGame();
                    g.Game();
                }
                else if (choice == 2)
                {
                    NetworkPing n = new NetworkPing();
                    n.Pinging();
                }
                else if (choice == 3)
                {
                    Fibo f = new Fibo();
                    f.Sequence();
                }
                else if (choice == 4)
                {
                    CountDown c = new CountDown();
                    c.Count();
                }
                else if (choice == 5)
                {
                    Bank b = new Bank();
                    b.RunBank();
                }
                else if (choice == 9)
                {
                    Console.WriteLine("Press any key to Exit");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please make a new selection");
                    choice = 0;
                }
            }
        }
    }
}
