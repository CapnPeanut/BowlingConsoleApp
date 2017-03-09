using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            
    

        }

        public void Bowling()
        {
            // What variables will be needed
            var rollsCount = 1;
            var score = 0;
            var frameScore = 0;
            var NextRollOne = 0;
            var NextRollTwo = 0;

            for (int frames = 0; frames < 9; frames++)
            {


                if (frames == 9 && rollsCount <= 2)
                {
                    Console.WriteLine("Enter the number of pins knocked down on roll " + rollsCount);
                    int rollOne = Convert.ToInt32(Console.ReadLine());
                    if (rollOne == 10)
                    {
                        frameScore = 10;
                        
                        score += frameScore + NextRollOne + NextRollTwo;
                        Console.WriteLine("Your score this frame was " + frameScore + " and your total score is " + score);
                        rollsCount = 3;

                    }
                    else
                    {

                        rollsCount += 1;
                        Console.WriteLine("Enter the number of pins knocked down on roll " + rollsCount);
                        int rollTwo = Convert.ToInt32(Console.ReadLine());
                        rollsCount += 1;
                        frameScore = rollTwo + rollOne;
                        score += frameScore;
                        Console.WriteLine("Your score this frame was " + frameScore + " and your total score is " + score);
                    }

                }
                else if (frames <= 8 && rollsCount <= 1)
                {






                }
                // Game has passed 10 frames and should be ended
                else
                {
                    Console.WriteLine("Your game is over and your total score is " + score);
                }

            }

        }

       
    }
}
