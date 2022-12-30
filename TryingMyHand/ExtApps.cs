using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning
{
    internal class ExtApps
    {

        public static void OpenPR()
        {
            try
            {



            
                using (Process photoViewer = new Process())
                {
                    photoViewer.StartInfo.UseShellExecute = true;
                    photoViewer.StartInfo.FileName = @"C:\WINDOWS\system32\mspaint.exe";

                    /*
                        Process photoViewer = new Process();
                        photoViewer.StartInfo.FileName = @"C:\WINDOWS\system32\mspaint.exe";
                        photoViewer.StartInfo.Arguments = @"C:\Users\David Dorn\source\repos\TryingMyHand\TryingMyHand\imgs\keepCalm.jpg";
                        photoViewer.Start();
                    */
              
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            
        }

    }
}
