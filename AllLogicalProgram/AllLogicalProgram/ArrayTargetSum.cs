
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class ArrayTargetSum
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2, 7, 11, 15, 3, 6 };
            int target = 9;

            bool found = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        Console.WriteLine($"Pair found: {arr[i]}, {arr[j]}");
                        found = true;
                    }
                }
            }

            if (!found)
                Console.WriteLine("No pair found with the given target.");
        }
    }
}
