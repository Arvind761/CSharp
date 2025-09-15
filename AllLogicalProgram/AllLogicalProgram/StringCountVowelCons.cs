using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class StringCountVowelCons
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter A string");
            string str = Console.ReadLine();

            int countVowel = 0, countConso = 0;
            foreach (char ch in str)
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' ||ch=='u'|| ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                { countVowel++; }
                else { countConso++; }
            }
            Console.WriteLine($"{str} inside string vowels={countVowel} and consonant={countConso}");
                
                
        }
    }
}
