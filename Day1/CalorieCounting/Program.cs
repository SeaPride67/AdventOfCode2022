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

        private class SortIntDescending : IComparer<int>
        {
            int IComparer<int>.Compare(int a, int b) //implement Compare
            {
                if (a > b)
                    return -1; //normally greater than = 1
                if (a < b)
                    return 1; // normally smaller than = -1
                else
                    return 0; // equal
            }
        }

        static int maxCalories = 0;
        static int minCalories = 9999999;
        static int curValue = 0;
        static int curCalories = 0;
        static List<int> listCalories;

        static void Main(string[] args)
        {

            CountCalories();
        }

        static bool CountCalories()
        {

            StreamReader sr = new StreamReader("input.txt");
            string dataIn;

            listCalories = new List<int>();

            while (sr.Peek() >= 0)
            {

                dataIn = sr.ReadLine();
                if (dataIn.Trim().Length == 0)
                {
                    System.Console.WriteLine("Empty");
                    listCalories.Add(curCalories);
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

            listCalories.Sort(new SortIntDescending());
            System.Console.WriteLine("listCalories[0]=" + listCalories[0].ToString());
            System.Console.WriteLine("listCalories[1]=" + listCalories[1].ToString());
            System.Console.WriteLine("listCalories[2]=" + listCalories[2].ToString());
            System.Console.WriteLine("sum of top three = " + (listCalories[0]+ listCalories[1]+ listCalories[2]).ToString());
            sr.Close();

            return (true);

        }
    }
}
