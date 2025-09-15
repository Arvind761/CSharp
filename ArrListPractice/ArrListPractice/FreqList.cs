using System.Collections;

namespace ArrListPractice
{
    internal class FreqList
    {
        public static void Main(String[] args)
        {
            ArrayList fruits = new ArrayList() { "Apple", "Banana", "Apple", "Cherry", "Banana", "Apple" };

            Dictionary<object, int> freq = new Dictionary<object, int>();

            foreach(var item in fruits)
            {
                if (freq.ContainsKey(item))
                {
                    freq[item]++;
                }
                else
                {
                    freq[item] = 1;
                }
            }

            Console.WriteLine("Frequency Element:");
            foreach(var kvp in freq)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }
    }
}
