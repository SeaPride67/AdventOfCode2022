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
            string dataIn1;
            string dataIn2;
            string dataIn3;
            int i = 0;
            int j = 0;
            int k = 0;
            int sumPriority = 0;
            int curPriority = 0;

            while (sr.Peek() >= 0)
            {

                dataIn1 = sr.ReadLine();
                dataIn2 = sr.ReadLine();
                dataIn3 = sr.ReadLine();

                for (i = 0; i < dataIn1.Length; i++)
                {
                    for (j = 0; j < dataIn2.Length; j++)
                    {
                        if (dataIn1[i] == dataIn2[j])
                        {
                            for (k = 0; k < dataIn3.Length; k++)
                            {
                                if (dataIn2[j] == dataIn3[k])
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
                                    i = dataIn1.Length;
                                    j = dataIn2.Length;
                                    k = dataIn3.Length;
                                } // if
                            } // for
                        } // if
                    } // for
                } // for

            } // while

            sr.Close();

        }
    }
}
