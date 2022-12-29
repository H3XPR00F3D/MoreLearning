using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MoreLearning
{
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
            Console.WriteLine(" |                                 6) Pong                             |");
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
    }

}
