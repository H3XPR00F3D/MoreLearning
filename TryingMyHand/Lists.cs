using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoreLearning;


namespace MoreLearning
{
    public class SelectionLists
    {
        public void Apps()
        {
            List<App> lst = new List<App>();

            lst.Add(new App{ AppName = "Guessing Game", AppID = 1 });
            lst.Add(new App { AppName = "Network Pinger", AppID = 2 });
            lst.Add(new App { AppName = "Fibonacci Sequence", AppID = 3 });
            lst.Add(new App { AppName = "Count Down", AppID = 4 });
            lst.Add(new App { AppName = "BankEx", AppID = 5 });

            lst.Add(new App { AppName = "Exit", AppID = 9 });


            foreach (App app in lst)
            {
                Console.WriteLine(app.AppID.ToString() + " " + app.AppName);
            }
        }
    }
}

