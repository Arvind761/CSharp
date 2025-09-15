using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class ArrayFreqeuncyEle
    {
        static void Main()
        {
            Console.Write("Enter array length: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            bool[] counted = new bool[n];
            for (int i = 0; i < n; i++)
            {
                if (counted[i])
                    continue;  // skip if already counted

                int count = 1;  // count current element
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        counted[j] = true; // mark as counted
                    }
                }

                Console.WriteLine($"{arr[i]} occurs {count} time(s)");
            }
        }
    }
}
