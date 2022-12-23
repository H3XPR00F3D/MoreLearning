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

            lst.Add(new App{ AppName = "GuessingGame", AppID = 1 });
            lst.Add(new App { AppName = "Network Pinger", AppID = 2 });
            lst.Add(new App { AppName = "Fibonacci Sequence", AppID = 3 });

            foreach (App app in lst)
            {
                Console.WriteLine(app.AppID.ToString() + " " + app.AppName);
            }
        }
    }
}

