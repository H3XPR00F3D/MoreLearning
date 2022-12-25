

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning
{
    public class CountDown
    {
        public static void Count()
        {
            string name;
            int age;

            Console.Write("What is your name?");
            name = Console.ReadLine();

            Console.Write("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());

            int countdown = 100 - age;

            Console.WriteLine(name + " you have " + countdown.ToString() + " more years until you are 100!!");

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();


        }
    }
}

