using System.Collections;

namespace ArrListPractice
{
    internal class RemoveAllEvenNo
    {
        public static void Main(string[] args)
        {   
            ArrayList arlist = new ArrayList() { 10, 21, 32 ,43 ,54, 65 ,76 };

            for(int i=0;i<arlist.Count;i++)
            {
                int num=(int)arlist[i];
                if (num % 2 == 0)
                {
                    arlist.RemoveAt(i);

                }
            }
            Console.WriteLine("After Removing Even Number");
            foreach(int i in arlist)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
