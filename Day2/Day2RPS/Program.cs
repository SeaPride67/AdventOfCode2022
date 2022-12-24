using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day2RPS
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader("C:\\Users\\CoreyPrideaux\\source\\repos\\AdventOfCode2022\\input_day2.txt");
            string dataIn;
            char opponentsPlay;
            char responsePlay;
            int curScore = 0;

            while (sr.Peek() >= 0)
            {

                dataIn = sr.ReadLine();
                opponentsPlay = dataIn[0];
                responsePlay = dataIn[2];

                if (opponentsPlay == 'A')   // Rock
                {
                    if (responsePlay == 'X') // Rock
                    {
                        curScore += 1;
                        curScore += 3;
                    } // if
                    else if (responsePlay == 'Y') // Paper
                    {
                        curScore += 2;
                        curScore += 6;
                    } // else if
                    else if (responsePlay == 'Z') // Scissors
                    {
                        curScore += 3;
                    } // else if
                    else
                    { 
                    } // else
                } // if
                else if (opponentsPlay == 'B') // Paper
                {
                    if (responsePlay == 'X') // Rock
                    {
                        curScore += 1;
                    } // if
                    else if (responsePlay == 'Y') // Paper
                    {
                        curScore += 2;
                        curScore += 3;
                    } // else if
                    else if (responsePlay == 'Z') // Scissors
                    {
                        curScore += 3;
                        curScore += 6;
                    } // else if
                    else
                    {
                    } // else
                } // else if
                else if (opponentsPlay == 'C') // Scissors
                {
                    if (responsePlay == 'X') // Rock
                    {
                        curScore += 1;
                        curScore += 6;
                    } // if
                    else if (responsePlay == 'Y') // Paper
                    {
                        curScore += 2;
                    } // else if
                    else if (responsePlay == 'Z') // Scissors
                    {
                        curScore += 3;
                        curScore += 3;
                    } // else if
                    else
                    {
                    } // else
                } // else if
                else
                {
                } // else

            } // while

            sr.Close();

        }
    }
}
