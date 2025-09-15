using System.Collections;

namespace ArrListPractice
{
    internal class RevList
    {
        public static void Main(string[] args)
        {
            ArrayList arlist = new ArrayList() { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            Console.WriteLine("Before Reverse Arrlist:");
            foreach (var furitsName in arlist)
            {
                Console.Write($"{furitsName} ");

            }
            int n=arlist.Count;
            for(int i = 0; i < n / 2; i++)
            {
                object temp = arlist[i];
                arlist[i] = arlist[n - 1 - i];
                arlist[n - 1 - i] = temp;
            }
            
            Console.WriteLine();
            Console.WriteLine("After Reverse Arrlist:");
            foreach (var furitsName in arlist)
            {
                Console.Write($"{furitsName} ");

            }

            Console.ReadLine();

        }
    }
}
