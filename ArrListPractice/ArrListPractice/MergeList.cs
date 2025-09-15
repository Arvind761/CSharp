using System.Collections;

namespace ArrListPractice
{
    internal class MergeList
    {
        public static void Main(String[] args)
        {
            ArrayList arlist1 = new ArrayList() { 5, 2, 8, 1 };
            ArrayList arlist2 = new ArrayList() { 5, 2, 8, 1 };

            for (int i = 0; i < arlist2.Count; i++)
            {
                arlist1.Add(arlist2[i]);
            }
            arlist1.Sort();
            Console.WriteLine("After Merge two List final:");
            foreach(var item in arlist1)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
