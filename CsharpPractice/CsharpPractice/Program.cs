using System;

namespace CsharpPractice
{
    internal class Program
    {
        public void Test1()
        {
            Console.WriteLine("This is Test1");
        }
        public void Test2()
        {
            Console.WriteLine("This is Test2");
        }
        public void Test3()
        {
            Console.WriteLine("This is Test3");
        }
        public void Test4()
        {
            Console.WriteLine("This is Test4");
        }
        public static void Main(string[] args)
        {
            Program P = new Program();
            P.Test1();
            P.Test2();
            P.Test3();
            P.Test4();
         
        }
    }
}