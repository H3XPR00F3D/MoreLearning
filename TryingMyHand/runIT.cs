using MoreLearning.Collections;
using MoreLearning.Dungeon;

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
                        Console.Clear();
                        Engine.Start();
                        break;
                    case 7:
                        Console.Clear();
                        NumArray.RunArray();
                        break;
                    case 8:
                        Console.Clear();
                        Scrapes.RunScrapes();
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

    public class UserPrompts
    {
        public static void Prompt()
        {
            Console.WriteLine("Please make a new selection");
            Console.WriteLine("  _____________________________________________________________________");
            Console.WriteLine(" |                                                                     |");
            Console.WriteLine(" |                           PRACTICE COLLECTION                       |");
            Console.WriteLine(" |                         C# CONSOLE APPLICATIONS                     |");
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
            Console.WriteLine(" |                                 6) DUNGEON                          |");
            Console.WriteLine(" |                              7) Number Array                        |");
            Console.WriteLine(" |                              8) SCRAPERS                            |");
            Console.WriteLine(" |                             9) EXIT PROGRAM                         |");
            Console.WriteLine(" |                                                                     |");
            Console.WriteLine(" |_____________________________________________________________________|");
            Console.WriteLine();
        }
        public static void UserNameReq()
        {
            Console.Write("What is your name?");
        }
        public static void UserAgeReq()
        {
            Console.Write("What is your age?");
        }
        public static void CalcToHund(string nameInput, int ageInput)
        {

            int countdown = 100 - ageInput;
            Console.WriteLine(nameInput + " you have " + countdown.ToString() + " more years until you are 100!!");
        }

        public static void ScrapePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("  _____________________________________________________________________");
            Console.WriteLine(" |                                                                     |");
            Console.WriteLine(" |                         PRACTICE COLLECTION                         |");
            Console.WriteLine(" |                           C# WEB SCRAPERS                           |");
            Console.WriteLine(" |                                                                     |");
            Console.WriteLine(" |_____________________________________________________________________|");
            Console.WriteLine(" |              PLEASE TYPE THE NUMBER ASSOCIATED WITH THE             |");
            Console.WriteLine(" |                             WEB SCRAPER                             |");
            Console.WriteLine(" |_____________________________________________________________________|");
            Console.WriteLine(" |                                                                     |");
            Console.WriteLine(" |                    1) WIKIPEDIA'S GREECE PAGE                       |");
            Console.WriteLine(" |                    2) DAUGHTERS OF KHAINE WARSCROLL                 |");
            Console.WriteLine(" |                    3)                                               |");
            Console.WriteLine(" |                    4)                                               |");
            Console.WriteLine(" |                    5)                                               |");
            Console.WriteLine(" |                    6)                                               |");
            Console.WriteLine(" |                    7)                                               |");
            Console.WriteLine(" |                    8)                                               |");
            Console.WriteLine(" |                    9) EXIT MENU                                     |");
            Console.WriteLine(" |                                                                     |");
            Console.WriteLine(" |_____________________________________________________________________|");
            Console.WriteLine();
        }

        public static void Continue()
        {
            Console.WriteLine("Press Enter to continue.");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            while (keyInfo.Key != ConsoleKey.Enter)
                keyInfo = Console.ReadKey();
        }

        public static void SelectAgain()
        {
            Console.Write("Please select a different option.");
        }

        public static void Disabled()
        {
            Console.WriteLine("The app has been temporarily disabled");
            //ExtApps.OpenPR();
        }


        public static void ToCont()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }

        //---------------------------------------------------------------------
        //Exit Prompts
        //---------------------------------------------------------------------
        public static void ExitApp()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
        public static void ExitApp(string empty)
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
        //---------------------------------------------------------------------
    }

}

