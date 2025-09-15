using System.Collections;

namespace ArrListPractice
{
    internal class OngList
    {
        public static void Main(string[] args)
        {
            ArrayList arlist = new ArrayList() { "Apple", "Banana", "Cherry" ,"Date" ,"Elderberry" };

            Console.WriteLine("Before Swapping Arrlist:");
            foreach (var furitsName in arlist) {
                Console.Write($"{furitsName} ");
            
            }

            (arlist[0], arlist[arlist.Count - 1]) = (arlist[arlist.Count - 1], arlist[0]);
            Console.WriteLine();
            Console.WriteLine("After Swapping Arrlist:");
            foreach (var furitsName in arlist)
            {
                Console.Write($"{furitsName} ");

            }

            Console.ReadLine();

        }
    }
}
