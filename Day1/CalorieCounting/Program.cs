using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace CalorieCounting
{
    class Program
    {

        static int maxCalories = 0;
        static int minCalories = 9999999;
        static int curValue = 0;
        static int curCalories = 0;

        static void Main(string[] args)
        {

            CountCalories();
        }

        static bool CountCalories()
        {

            StreamReader sr = new StreamReader("input.txt");
            string dataIn;

            while (sr.Peek() >= 0)
            {

                dataIn = sr.ReadLine();
                if (dataIn.Trim().Length == 0)
                {
                    System.Console.WriteLine("Empty");
                    if (curCalories <= minCalories) minCalories = curCalories;
                    if (curCalories >= maxCalories) maxCalories = curCalories;
                    curCalories = 0;
                }
                else
                {
                    curValue = 0;
                    if (!int.TryParse(dataIn, out curValue))
                    {
                        System.Console.WriteLine("Unable to parse value for " + dataIn + " press a key to continue...");
                        System.Console.ReadKey();
                    }
                    else
                    {
                        curCalories += curValue;
                    }

                }
                //System.Console.WriteLine(dataIn);

            }

            System.Console.WriteLine("minCalories=" + minCalories.ToString());
            System.Console.WriteLine("maxCalories=" + maxCalories.ToString());

            sr.Close();

            return (true);

        }
    }
}
