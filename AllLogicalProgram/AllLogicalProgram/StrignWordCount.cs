using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class StrignWordCount
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            int wordCount = 0;
            bool inWord=false;

            for(int i = 0; i < sentence.Length; i++)
            {
                char ch=sentence[i];
                if (ch != ' ' && !inWord)
                {
                    inWord = true;
                    wordCount++;
                }
                else if(ch== ' ') {
                
                    inWord=false;
                }
            }
            Console.WriteLine($"Number of words: {wordCount}");
        }
    }
}
