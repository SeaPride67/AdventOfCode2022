using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader("input_day4.txt");
            String dataIn;
            String[] tokensIn;
            char[] seps = { ',', '-' };
            int n = 0;
            int x = 0;
            int low1, low2, high1, high2;

            while (sr.Peek() != -1)
            {
                dataIn = (sr.ReadLine());
                tokensIn = dataIn.Split(seps);
                low1 = int.Parse(tokensIn[0]);
                high1 = int.Parse(tokensIn[1]);
                low2 = int.Parse(tokensIn[2]);
                high2 = int.Parse(tokensIn[3]);

                // part 1
                if ((low2 >= low1 && high2 <= high1) ||
                   (low1 >= low2 && high1 <= high2))
                {
                    n++;
                }

                // part 2
                if ((low1 >= low2 && low1 <= high2) ||
                    (high1 >= low2 && high1 <= high2) ||
                    (low2 >= low1 && low2 <= high1) ||
                    (high2 >= low1 && high2 <= high1))
                    x++;

            }

            sr.Close();

        }
    }
}
