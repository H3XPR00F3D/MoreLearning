﻿using MoreLearning.Pong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MoreLearning
{
    public class RunIT
    {




public static void Main()
        {
            bool reload = true;
            while (reload == true)
            {
                ProjectSelection();
            }
        }




        public static void ProjectSelection()
        {
            int choice = 0;


            while (choice == 0)
            {

                UserPrompts.Prompt();

                SelectionLists s = new SelectionLists();
            //    s.Apps();

                Console.WriteLine();
                choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        GuessingGame.Game();
                        break;
                    case 2:
                        NetworkPing.Pinging();
                        break;
                    case 3:
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
                        Console.Clear();
                        PongGame.RunGame();
                        break;
                    case 7:
                        Console.Clear();
                        NumArray.RunArray();
                        break;
                    case 8:
                        break;
                    case 9:
                        UserPrompts.ExitApp();
                        Environment.Exit(0);
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


