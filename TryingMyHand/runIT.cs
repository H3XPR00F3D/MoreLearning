using MoreLearning.Collections;
using MoreLearning.Dungeon;
using System.Diagnostics;
namespace MoreLearning
{
    public class runIT
    {
        public static void Main(string[] args)
        {

            Player player = new Player();
            //Engine.ConsoleFull();
            bool reload = true;
            while (reload == true)
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = false,
                        Arguments = "/c YourConsoleApp.exe -arg1 player"
                    }
                };
                process.Start();
                Console.WriteLine(process.StandardOutput.ReadToEnd());
                process.WaitForExit();
            }
        }
    }  
    class Selector
    {
        public static void ProjectSelection()
        {
            int choice = 0;
            var e = new Engine();
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
                        Old_Collection.Collection();
                        break;
                    case 2:
                        UserPrompts.Disabled();
                        ProjectSelection();
                        break;
                    case 3:
                        Console.Clear();
               //         e.Run();
                        break;
                    case 4:
                        UserPrompts.Disabled();
                        ProjectSelection();
                        break;
                    case 5:
                        Console.Clear();
                        Scrapes.RunScrapes();
                        break;
                    case 6:
                        UserPrompts.Disabled();
                        ProjectSelection();
                        break;
                    case 7:
                        UserPrompts.Disabled();
                        ProjectSelection();
                        break;
                    case 8:
                        UserPrompts.Disabled();
                        ProjectSelection();
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
            Console.WriteLine();
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
            Console.WriteLine(" |                          1) OLD COLLECTION                          |");
            Console.WriteLine(" |                          2)                                         |");
            Console.WriteLine(" |                          3) TEST DUNGEON                            |");
            Console.WriteLine(" |                          4)                                         |");
            Console.WriteLine(" |                          5) TEST SCRAPERS                           |");
            Console.WriteLine(" |                          6)                                         |");
            Console.WriteLine(" |                          7)                                         |");
            Console.WriteLine(" |                          8)                                         |");
            Console.WriteLine(" |                          9) EXIT PROGRAM                            |");
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
        public static void CollectionsPrompt()
        {
            Console.WriteLine();
            Console.WriteLine("  _____________________________________________________________________");
            Console.WriteLine(" |                                                                     |");
            Console.WriteLine(" |                           PRACTICE COLLECTION                       |");
            Console.WriteLine(" |                                                                     |");
            Console.WriteLine(" |                                                                     |");
            Console.WriteLine(" |_____________________________________________________________________|");
            Console.WriteLine(" |               PLEASE TYPE THE NUMBER OF THE ASSOCIATED APP YOU      |");
            Console.WriteLine(" |                          WOULD LIKE TO TRY OUT.                     |");
            Console.WriteLine(" |_____________________________________________________________________|");
            Console.WriteLine(" |                                                                     |");
            Console.WriteLine(" |                          1) GUESSING GAME                          |");
            Console.WriteLine(" |                          2) NETWORK PING                                        |");
            Console.WriteLine(" |                          3) FIBONACCI                            |");
            Console.WriteLine(" |                          4) AGE COUNTDOWN                                        |");
            Console.WriteLine(" |                          5) SIMPLE BANK ACCT                           |");
            Console.WriteLine(" |                          6)                                         |");
            Console.WriteLine(" |                          7) NUM ARRAY                                        |");
            Console.WriteLine(" |                          8)                                         |");
            Console.WriteLine(" |                          9) EXIT PROGRAM                            |");
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
            Console.Clear();
            Console.Write("Please select a different option.");
        }
        public static void Disabled()
        {
            Console.Clear();
            Console.WriteLine("The app has been temporarily disabled");
            Console.Write("Please select a different option.");
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