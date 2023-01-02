using MoreLearning.Dungeon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Collections
{
    public class Old_Collection
    {
        public static void Collection()
        {
                int choice = 0;

                while (choice == 0)
                {
                    UserPrompts.CollectionsPrompt();
                    SelectionLists s = new SelectionLists();
                    Console.WriteLine();
                    choice = Convert.ToInt32(Console.ReadLine());


                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            GuessingGame.Game();
                            break;
                        case 2:
                            Console.Clear();
                            NetworkPing.Pinging();
                            UserPrompts.ToCont();
                            break;
                        case 3:
                            Console.Clear();
                            Fibo.Sequence();
                            break;
                        case 4:
                            Console.Clear();
                            CountDown.Count();
                            break;
                        case 5:
                            Bank b = new Bank();
                            b.RunBank();
                            break;
                        case 6:
                        UserPrompts.Disabled();
                        Collection();
                        break;
                        case 7:
                            Console.Clear();
                            NumArray.RunArray();
                            break;
                        case 8:
                        UserPrompts.Disabled();
                        Collection();
                          break;
                        case 9:
                            UserPrompts.ExitApp();
                            Environment.Exit(0);
                            break;
                        case 10:


                            break;
                        default:
                            UserPrompts.Prompt();
                            choice = 0;
                            break;
                    }
                }
            }
       



    }
}
