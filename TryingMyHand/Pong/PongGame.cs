using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Pong
{
    public class PongGame
    {
        public static void RunGame()
        {
            const int fieldLength = 50, fieldWidth = 15;
            const char fieldTile = '#';
            string line = string.Concat(Enumerable.Repeat(fieldTile, fieldLength));

            const int racketLength = fieldWidth / 4;
            const char racketTile = '|';

            int leftRacketHeight = 0;
            int rightRacketHeight = 0;

            while(true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(line);

                Console.SetCursorPosition(0, fieldWidth);
                Console.WriteLine(line);

                for (int i=0;1<racketLength;i++)
                {


                    Console.SetCursorPosition(0,i+1+leftRacketHeight);
                    Console.WriteLine(racketTile);
                    Console.SetCursorPosition(fieldLength-1, i+1+rightRacketHeight);
                    Console.WriteLine(racketTile);
                }
            }


        }
    }
}
