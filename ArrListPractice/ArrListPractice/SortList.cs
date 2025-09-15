using System.Collections;

namespace ArrListPractice
{
    internal class SortList
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { 4,5,53,35,3,6,1,2,7};

            Console.WriteLine("List Before Sorting:");
            foreach(var i in list)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine();
            list.Sort();
            Console.WriteLine("List after Sorting:");
            foreach(var i in list)
            {
                Console.Write($"{i}  ");
            }
            Console.ReadLine();
        }
    }
}
