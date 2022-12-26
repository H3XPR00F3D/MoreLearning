using MoreLearning.Pong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning
{
   public class RunIT
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

                Console.WriteLine(" _______________________________________________________________________");
                Console.WriteLine(" |                                                                     |");
                Console.WriteLine(" |                            PRACTICE COLLECTION                      |");
                Console.WriteLine(" |                          C# CONSOLE APPLICATIONS                    |");
                Console.WriteLine(" |                                                                     |");                                                                                                                   
                Console.WriteLine(" |_____________________________________________________________________|");
                Console.WriteLine(" |               PLEASE TYPE THE NUMBER OF THE ASSOCIATED APP YOU      |");
                Console.WriteLine(" |                          WOULD LIKE TO TRY OUT.                     |");
                Console.WriteLine(" |_____________________________________________________________________|");
                Console.WriteLine(" |                                                                     |");                                                                                                                 
                Console.WriteLine(" |                             1) GUESSING GAME                        |");
                Console.WriteLine(" |                          2) GOOGLE NETWORK PING                     |");
                Console.WriteLine(" |                          3) FIBONACCI SEQUENCE                      |");
                Console.WriteLine(" |                            4) AGE COUNTDOWN                         |");
                Console.WriteLine(" |                        5) BANK ACCOUNT SIMULATOR                    |");
                Console.WriteLine(" |6) Pong                                                              |");
                Console.WriteLine(" |7)                                                                   |");
                Console.WriteLine(" |8)                                                                   |");
                Console.WriteLine(" |                             9) EXIT PROGRAM                         |");
                Console.WriteLine(" |                                                                     |");
                Console.WriteLine(" |_____________________________________________________________________|");
                Console.WriteLine();

                SelectionLists s = new SelectionLists();
            //    s.Apps();

                Console.WriteLine();
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    GuessingGame.Game();
                    Run();
                }
                else if (choice == 2)
                { 
                   NetworkPing.Pinging();
                   Run();
                }
                else if (choice == 3)
                {
                   
                    Fibo.Sequence();
                    Run();
                }
                else if (choice == 4)
                {
                    Console.Clear();
                    CountDown.Count();
                    Run();
                }
                else if (choice == 5)
                {
                    Bank b = new Bank();
                    b.RunBank();
                    Run();
                }
                else if (choice == 6)
                {
                    Console.Clear();
                    PongGame.RunGame();
                    Run();
                }
                else if (choice == 7)
                {
                    Console.Clear();
                    NumArray.RunArray();
                    Run();
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
                    Console.WriteLine(" _______________________________________________________________________");
                    Console.WriteLine(" |                                                                     |");
                    Console.WriteLine(" |                            PRACTICE COLLECTION                      |");
                    Console.WriteLine(" |                          C# CONSOLE APPLICATIONS                    |");
                    Console.WriteLine(" |                                                                     |");
                    Console.WriteLine(" |_____________________________________________________________________|");
                    Console.WriteLine(" |               PLEASE TYPE THE NUMBER OF THE ASSOCIATED APP YOU      |");
                    Console.WriteLine(" |                          WOULD LIKE TO TRY OUT.                     |");
                    Console.WriteLine(" |_____________________________________________________________________|");
                    Console.WriteLine(" |                                                                     |");
                    Console.WriteLine(" |                             1) GUESSING GAME                        |");
                    Console.WriteLine(" |                          2) GOOGLE NETWORK PING                     |");
                    Console.WriteLine(" |                          3) FIBONACCI SEQUENCE                      |");
                    Console.WriteLine(" |                            4) AGE COUNTDOWN                         |");
                    Console.WriteLine(" |                        5) BANK ACCOUNT SIMULATOR                    |");
                    Console.WriteLine(" |6)Pong Game                                                                   |");
                    Console.WriteLine(" |7)                                                                   |");
                    Console.WriteLine(" |8)                                                                   |");
                    Console.WriteLine(" |                             9) EXIT PROGRAM                         |");
                    Console.WriteLine(" |                                                                     |");
                    Console.WriteLine(" |_____________________________________________________________________|");
                    Console.WriteLine();
                    choice = 0;
                }
            }
        }
    }
}


