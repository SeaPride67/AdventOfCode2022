using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader("C:\\Users\\CoreyPrideaux\\source\\repos\\AdventOfCode2022\\input_day3.txt");
            string dataIn;
            string dataIn1;
            string dataIn2;
            int i = 0;
            int j = 0;
            int sumPriority = 0;
            int curPriority = 0;

            while (sr.Peek() >= 0)
            {

                dataIn = sr.ReadLine();

                if ((dataIn.Length % 2) != 0)
                {
                    System.Console.WriteLine("Invalid length for dataIn, " + dataIn.Length);
                    System.Console.ReadKey();
                    break;
                } // if

                dataIn1 = dataIn.Substring(0, dataIn.Length / 2);
                dataIn2 = dataIn.Substring(dataIn.Length / 2, dataIn.Length - dataIn.Length / 2);

                for (i = 0; i < dataIn1.Length; i++)
                {
                    for (j = 0; j < dataIn2.Length; j++)
                    {
                        if (dataIn1[i] == dataIn2[j])
                        {
                            if (dataIn1[i] >= 'a' && dataIn1[i] <= 'z')
                            {
                                curPriority = (dataIn1[i] - 'a') + 1;
                                sumPriority += curPriority;
                            } // if
                            else
                            {
                                curPriority = (dataIn1[i] - 'A') + 27;
                                sumPriority += curPriority;
                            } // else
                            System.Console.WriteLine("dataIn1=" + dataIn1);
                            System.Console.WriteLine("dataIn2=" + dataIn2);
                            System.Console.WriteLine("dataIn1[i]=" + dataIn1[i] + "\ndataIn2[j]=" + dataIn2[j]);
                            System.Console.WriteLine("curPriority=" + curPriority.ToString() + " sumPriority=" + sumPriority.ToString() + "\n");
                            j = dataIn2.Length;
                            i = dataIn1.Length;
                        }
                    } // for
                } // for

            } // while

            sr.Close();

        }
    }
}
