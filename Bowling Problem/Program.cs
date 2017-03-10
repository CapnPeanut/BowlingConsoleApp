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
            
            

        


            // What variables will be needed
            var score = 0;
            var frameScore = 0;
            int[] ScoreCard = new int[23] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            var scoreCardIndex = 0;

            for (int frames = 1; frames <= 10; frames++)
            {
                Console.WriteLine("You are on frame " + frames);
                Console.WriteLine("Enter the number of pins knocked down on roll 1 ");
                int rollOne = Convert.ToInt32(Console.ReadLine());

                if (frames == 10)
                {

                        if (rollOne == 10)
                        {
                        ScoreCard[scoreCardIndex] = 10;
                        frameScore = 10;
                        score += frameScore;
                        Console.WriteLine("Your score this frame was " + frameScore + " and your total score is " + score);
                        scoreCardIndex += 1;
                        Console.WriteLine("Enter the number of pins knocked down on roll 2");
                        int rollTwo = Convert.ToInt32(Console.ReadLine());
                        scoreCardIndex += 1;
                        ScoreCard[scoreCardIndex] = rollTwo;
                        if (rollTwo == 10)
                        {
                            Console.WriteLine("Enter the number of pins knocked down on roll 3");
                            int rollThree = Convert.ToInt32(Console.ReadLine());
                            scoreCardIndex += 1;
                            ScoreCard[scoreCardIndex] = rollThree;
                            Console.WriteLine("Your game is over and your total score is " + score);
                        }

                        }
                    else
                        {
                        ScoreCard[scoreCardIndex] = rollOne;
                        frameScore = rollOne;
                        score += frameScore;
                        Console.WriteLine("Your score this frame was " + frameScore + " and your total score is " + score);
                        scoreCardIndex += 1;
                        Console.WriteLine("Enter the number of pins knocked down on roll 2");
                        int rollTwo = Convert.ToInt32(Console.ReadLine());
                        if (rollTwo + rollOne == 10)
                        {
                            ScoreCard[scoreCardIndex] = rollTwo;
                            Console.WriteLine("Enter the number of pins knocked down on roll 3");
                            int rollThree = Convert.ToInt32(Console.ReadLine());
                            ScoreCard[scoreCardIndex] = rollThree;
                            Console.WriteLine("Your game is over and your total score is " + score);
                        }
                        else
                        {
                            ScoreCard[scoreCardIndex] = rollTwo;
                            Console.WriteLine("Your game is over and your total score is " + score);
                        }
                                        

                                
                 }
                    

                }
                else if (frames <= 9)
                {
                    if (rollOne == 10)
                    {
                        ScoreCard[scoreCardIndex] = 10;
                        frameScore = 10;
                        score += frameScore;
                        Console.WriteLine("Your score this frame was " + frameScore + " and your total score is " + score);
                        scoreCardIndex += 2;

                    }
                    else
                    {
                        ScoreCard[scoreCardIndex] = rollOne;
                        frameScore = rollOne;
                        Console.WriteLine("Your score this frame is " + frameScore);
                        scoreCardIndex += 1;
                        Console.WriteLine("Enter the number of pins knocked down on roll 2");
                        int rollTwo = Convert.ToInt32(Console.ReadLine());
                            if (rollTwo + rollOne == 10)
                            {
                                frameScore = rollOne + rollTwo;
                            score += frameScore;
                            ScoreCard[scoreCardIndex] = rollTwo;
                                Console.WriteLine("Your score this frame was " + frameScore + " and your total score is " + score);
                            }
                            else
                            {
                            frameScore = rollOne + rollTwo;
                            score += frameScore;
                            ScoreCard[scoreCardIndex] = rollTwo;
                            Console.WriteLine("Your score this frame was " + frameScore + " and your total score is " + score);

                             }
                    }

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
