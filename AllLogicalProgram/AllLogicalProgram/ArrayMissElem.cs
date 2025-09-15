using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class ArrayMissElem
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter N (total numbers including missing one): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n - 1];
            Console.WriteLine($"Enter {n - 1} numbers (from 1 to {n}): ");
            for (int i = 0; i < n - 1; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //int expectedSum = n * (n + 1) / 2;
            //int actualSum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    actualSum += arr[i];
            //}

            //int missing = expectedSum - actualSum;
            //Console.WriteLine("Missing number is: " + missing);
            Array.Sort(arr);

            // Step 2: Check for missing number
            int missing = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != i + 1)
                {
                    missing = i + 1;
                    break;
                }
            }

            // If all matched, then last number N is missing
            if (missing == -1)
            {
                missing = n;
            }

            Console.WriteLine("Missing number is: " + missing);
        }
    
    }
}
