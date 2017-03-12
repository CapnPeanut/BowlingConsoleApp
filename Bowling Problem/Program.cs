using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Problem
{
    class Program
    {
        public static object Lists { get; private set; }

        static void Main(string[] args)
        {
            // declaring variables needed

            var frameIndex = 0;

            //declaring arrays needed

            int[] rolls = new int[21];

            // nesting arrays in array

            int[][] arrayOfArrays = new int[10][];
            for (int rowIndex = 0; rowIndex < arrayOfArrays.Length; rowIndex++)
            {
                arrayOfArrays[rowIndex] = new int[3];
                for (int colIndex = 0; colIndex < arrayOfArrays[rowIndex].Length; colIndex++)
                {
                    arrayOfArrays[rowIndex][colIndex] = new int();
                }
            }

            // playing through the turns

            for (int frame = 1; frame < arrayOfArrays.Length + 1; frame++)
                {



                    var rollsIndex = 0;
                    Console.WriteLine("Frame " + frame);
                    Console.WriteLine("Enter the number of pins knocked down on roll 1 ");
                    int rollOne = Convert.ToInt32(Console.ReadLine());
                    var rollCount = 0;


                    // Frame 10 is unique
                    if (frame == 10)
                    {

                        arrayOfArrays[frameIndex][rollCount] = rollOne;
                    if (rollOne == 10)
                    {
                        // 2nd roll  frame 10 if strike
                        rollCount += 1;
                        Console.WriteLine("Enter the number of pins knocked down on roll 2 ");
                        int rollTwo = Convert.ToInt32(Console.ReadLine());

                        arrayOfArrays[frameIndex][rollCount] = rollTwo;

                        // Third roll frame 10 if strike
                        rollCount += 1;
                        Console.WriteLine("Enter the number of pins knocked down on roll 3 ");
                        int rollThree = Convert.ToInt32(Console.ReadLine());

                        arrayOfArrays[frameIndex][rollCount] = rollThree;
                    }

                    else
                    {
                        rollCount += 1;
                        Console.WriteLine("Enter the number of pins knocked down on roll 2 ");
                        int rollTwo = Convert.ToInt32(Console.ReadLine());

                        arrayOfArrays[frameIndex][rollCount] = rollTwo;

                        // frame 10 spare
                        if (rollOne + rollTwo == 10)
                        {
                            // Third roll frame 10
                            rollCount += 1;
                            Console.WriteLine("Enter the number of pins knocked down on roll 3 ");
                            int rollThree = Convert.ToInt32(Console.ReadLine());

                            arrayOfArrays[frameIndex][rollCount] = rollThree;
                        }
                     }
                    }


                    else
                    {



                        arrayOfArrays[frameIndex][rollCount] = rollOne;
                        // normale turn strike
                        if (rollOne == 10)
                        {
                            frameIndex += 1;
                            continue;

                        }
                        else
                        {
                        //normal turn
                            rollCount += 1;
                            Console.WriteLine("Enter the number of pins knocked down on roll 2 ");
                            int rollTwo = Convert.ToInt32(Console.ReadLine());

                            arrayOfArrays[frameIndex][rollCount] = rollTwo;
                        }

                    }
                    frameIndex += 1;
                }











            //////////    Calculations


           


            for (int frameOfGame = 0; frameOfGame < arrayOfArrays.Length; frameOfGame++)
            {

                // calculating strikes
                var rollScore = 0;
                if (frameOfGame == 9 && arrayOfArrays[frameOfGame][rollScore] == 10)
                {
                    arrayOfArrays[frameOfGame][rollScore] = arrayOfArrays[frameOfGame][rollScore];

                }
                else if (frameOfGame == 9 && arrayOfArrays[frameOfGame][rollScore] + arrayOfArrays[frameOfGame][rollScore + 1] == 10)
                {
                    arrayOfArrays[frameOfGame][rollScore] = arrayOfArrays[frameOfGame][rollScore]; //+ arrayOfArrays[frameOfGame][rollScore + 1] + arrayOfArrays[frameOfGame][rollScore + 2];

                }
                else if (arrayOfArrays[frameOfGame][rollScore] == 10)
                {
                    if (arrayOfArrays[frameOfGame + 1][rollScore] == 10 && frameOfGame != 8 && frameOfGame != 9)
                    {
                        arrayOfArrays[frameOfGame][rollScore] = arrayOfArrays[frameOfGame][rollScore] + arrayOfArrays[frameOfGame + 1][rollScore] + arrayOfArrays[frameOfGame + 2][rollScore];
                        
                    }
                    else
                    {
                        arrayOfArrays[frameOfGame][rollScore] = arrayOfArrays[frameOfGame][rollScore] + arrayOfArrays[frameOfGame + 1][rollScore] + arrayOfArrays[frameOfGame + 1][rollScore + 1];
                        
                    }
                }
                //calculating spares
                else if (arrayOfArrays[frameOfGame][rollScore] + arrayOfArrays[frameOfGame][rollScore + 1] == 10)
                {
                    arrayOfArrays[frameOfGame][rollScore] = arrayOfArrays[frameOfGame][rollScore] + arrayOfArrays[frameOfGame + 1][rollScore];
                    

                }
                //calculating regualr scoring
                else
                {
                    

                }

            }



            /////////////////////////////////  My old work



            //var frameOfGame = 0;


            //for (int i = 0; i < arrayOfArrays.Length - 1; i++)
            //{

            //    // calculating strikes
            //    var rollScore = 0;
            //    if (i == 10 && arrayOfArrays[frameOfGame][rollScore] == 10)
            //    {
            //        arrayOfArrays[frameOfGame][rollScore] = arrayOfArrays[frameOfGame][rollScore] + arrayOfArrays[frameOfGame][rollScore + 1] + arrayOfArrays[frameOfGame][rollScore + 2];

            //    }
            //    else if (i == 10 && arrayOfArrays[frameOfGame][rollScore] + arrayOfArrays[frameOfGame][rollScore + 1] == 10)
            //    {
            //        arrayOfArrays[frameOfGame][rollScore] = arrayOfArrays[frameOfGame][rollScore] + arrayOfArrays[frameOfGame][rollScore + 1] + arrayOfArrays[frameOfGame][rollScore + 2];

            //    }
            //    else if (arrayOfArrays[frameOfGame][rollScore] == 10)
            //    {
            //        if (arrayOfArrays[frameOfGame + 1][rollScore] == 10 && i != 8 && i != 9)
            //        {
            //            arrayOfArrays[frameOfGame][rollScore] = arrayOfArrays[frameOfGame][rollScore] + arrayOfArrays[frameOfGame + 1][rollScore] + arrayOfArrays[frameOfGame + 2][rollScore];
            //            frameOfGame += 1;
            //        }
            //        else
            //        {
            //            arrayOfArrays[frameOfGame][rollScore] = arrayOfArrays[frameOfGame][rollScore] + arrayOfArrays[frameOfGame + 1][rollScore] + arrayOfArrays[frameOfGame + 1][rollScore + 1];
            //            frameOfGame += 1;
            //        }
            //    }
            //    //calculating spares
            //    else if (arrayOfArrays[frameOfGame][rollScore] + arrayOfArrays[frameOfGame][rollScore + 1] == 10)
            //    {
            //        arrayOfArrays[frameOfGame][rollScore] = arrayOfArrays[frameOfGame][rollScore] + arrayOfArrays[frameOfGame][rollScore + 1] + arrayOfArrays[frameOfGame + 1][rollScore];
            //        frameOfGame += 1;

            //    }
            //    //calculating regualr scoring
            //    else
            //    {
            //        frameOfGame += 1;

            //    }

            //}


            int score = 0;
            for (int i = 0; i < arrayOfArrays.Length; i++)
            {
                for (int j = 0; j < arrayOfArrays[i].Length; j++)
                {

                    score += arrayOfArrays[i][j];
                }
            }
            Console.WriteLine("Your final score is " + score);
            Console.ReadLine();   // placed so console doesn't close out

        }


    }
}





                    //////////////////////////////////////  My beginning working through the logic




//// What variables will be needed
//var score = 0;
//var frameScore = 0;
//int[] ScoreCard = new int[23] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
//var scoreCardIndex = 0;
//var spare = ScoreCard[scoreCardIndex] + (ScoreCard[scoreCardIndex] + 1);
//var strike = ScoreCard[scoreCardIndex] + (ScoreCard[scoreCardIndex] + 1) + (ScoreCard[scoreCardIndex] + 1);
//List<int> Strikes = new List<int>();
//List<int> Spares = new List<int>();

//for (int frames = 1; frames <= 10; frames++)
//{
//    Console.WriteLine("You are on frame " + frames);
//    Console.WriteLine("Enter the number of pins knocked down on roll 1 ");
//    int rollOne = Convert.ToInt32(Console.ReadLine());

//    if (frames == 10)
//    {

//            if (rollOne == 10)
//            {
//            frameScore = 10;
//            score += strike;
//            ScoreCard[scoreCardIndex] = strike;
//            Strikes.Add(scoreCardIndex);
//            Console.WriteLine("Your score this frame was " + frameScore + " and your total score is " + score);
//            scoreCardIndex += 1;
//            Console.WriteLine("Enter the number of pins knocked down on roll 2");
//            int rollTwo = Convert.ToInt32(Console.ReadLine());
//            scoreCardIndex += 1;
//            ScoreCard[scoreCardIndex] = rollTwo;
//                if (rollTwo == 10)
//                {
//                    ScoreCard[scoreCardIndex] = spare;
//                    Spares.Add(scoreCardIndex);
//                    Console.WriteLine("Enter the number of pins knocked down on roll 3");
//                    int rollThree = Convert.ToInt32(Console.ReadLine());
//                    scoreCardIndex += 1;
//                    ScoreCard[scoreCardIndex] = rollThree;
//                    Console.WriteLine("Your game is over and your total score is " + score);



//                    Console.WriteLine(ScoreCard);
//                    Console.ReadLine();
//                }
//                else
//                {
//                    Console.WriteLine("Enter the number of pins knocked down on roll 3");
//                    int rollThree = Convert.ToInt32(Console.ReadLine());
//                    scoreCardIndex += 1;
//                    ScoreCard[scoreCardIndex] = rollThree;
//                    Console.WriteLine("Your game is over and your total score is " + score);

//                    Console.WriteLine(ScoreCard);
//                    Console.ReadLine();
//                }

//                }
//                 else
//                {
//                ScoreCard[scoreCardIndex] = rollOne;
//                frameScore = rollOne;
//                score += frameScore;
//                Console.WriteLine("Your score this frame was " + frameScore + " and your total score is " + score);
//                scoreCardIndex += 1;
//                Console.WriteLine("Enter the number of pins knocked down on roll 2");
//                int rollTwo = Convert.ToInt32(Console.ReadLine());
//                    if (rollTwo + rollOne == 10)
//                    {
//                         ScoreCard[scoreCardIndex] = strike;
//                         Strikes.Add(scoreCardIndex);
//                         Console.WriteLine("Enter the number of pins knocked down on roll 3");
//                        int rollThree = Convert.ToInt32(Console.ReadLine());
//                        ScoreCard[scoreCardIndex] = rollThree;
//                        Console.WriteLine("Your game is over and your total score is " + score);
//                    }
//                    else
//                    {
//                        ScoreCard[scoreCardIndex] = rollTwo;
//                        Console.WriteLine("Your game is over and your total score is " + score);
//                        Console.WriteLine(ScoreCard);
//                        Console.ReadLine();
//                    }



//            }


//    }
//    else if (frames <= 9)
//    {
//        if (rollOne == 10)
//        {
//            ScoreCard[scoreCardIndex] = strike;
//            Strikes.Add(scoreCardIndex);
//            frameScore = 10;
//            score += frameScore;
//            Console.WriteLine("Your score this frame was " + frameScore + " and your total score is " + score);
//            scoreCardIndex += 2;

//        }
//        else
//        {
//            ScoreCard[scoreCardIndex] = rollOne;
//            frameScore = rollOne;
//            Console.WriteLine("Your score this frame is " + frameScore);
//            scoreCardIndex += 1;
//            Console.WriteLine("Enter the number of pins knocked down on roll 2");
//            int rollTwo = Convert.ToInt32(Console.ReadLine());
//                if (rollTwo + rollOne == 10)
//                {
//                ScoreCard[scoreCardIndex] = spare;
//                Spares.Add(scoreCardIndex);
//                frameScore = rollOne + rollTwo;
//                score += frameScore;
//                Console.WriteLine("Your score this frame was " + frameScore + " and your total score is " + score);
//                }
//                else
//                {
//                frameScore = rollOne + rollTwo;
//                score += frameScore;
//                ScoreCard[scoreCardIndex] = rollTwo;
//                Console.WriteLine("Your score this frame was " + frameScore + " and your total score is " + score);

//                 }
//        }

//    }
//    // Game has passed 10 frames and should be ended
//    else
//    {
//        Console.WriteLine("Your game is over and your total score is " + score);
//    }

//}

