using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dollar_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            //test1 
            int[] test1 = new int[]{2,5,10};
            int target1 = 16;
            int result = dollarchange(test1, target1);
            Console.WriteLine(result);

            //test2
            int[] test2 = new int[] { 3, 5, 10 };
            int target2 = 11;
            int result2 = dollarchange(test2, target2);
            Console.WriteLine(result2);

            Console.ReadKey();
            return;
        }
        private static int dollarchange(int[] dollars, int target)
        {
            int Dlength = dollars.Length;
            int[] table = new int[target + 1];

            table[0] = 0;
            for (int i = 1; i <= target; ++i)
            {
                table[i] = Int32.MaxValue;
            }

            int tlength = table.Length;
            for (int i = 1; i < tlength; ++i)
            {
                for (int j = 0; j < Dlength; ++j)
                {

                    if (dollars[j] <= i)
                    {
                        int sub = i - dollars[j];
                        if (table[sub] != Int32.MaxValue)
                        {
                            table[i] = Math.Min(table[i], table[sub] + 1);
                        }
                    }
                }
            }
            return table[target] == Int32.MaxValue ? -1 : table[target];
        }
    }
}
