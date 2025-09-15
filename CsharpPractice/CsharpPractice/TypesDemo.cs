using System;
namespace CsharpPractice
{
  
    class TypesDemo
    {
        static int x;
        public const int y = 10;
        public readonly int d;
       
        static void Main()
        {

            //Field
            decimal pi = 3.14m;
            Console.Clear();
            Console.WriteLine("Field x value is: " + x + " and it's type is: " + x.GetType());
            int y = 10;
            //Variable
            Console.WriteLine("Variable y value is: " + y + " and it's type is: " + y.GetType());
            float f = 3.14f;
            //Variable
            Console.WriteLine("Variable f value is: " + f + " and it's type is: " + f.GetType());
            double d = 3.14;
            //Variable
            Console.WriteLine("Variable d value is: " + d + " and it's type is: " + d.GetType());
            decimal de = 3.14m;
            //Variable
            Console.WriteLine("Variable de value is: " + de + " and it's type is: " + de.GetType());
            bool b = true;
            //Variable
            Console.WriteLine("Variable b value is: " + b + " and it's type is: " + b.GetType());
            Char ch = 'A';
            //Variable
            Console.WriteLine("Variable ch value is: " + ch + " and it's type is: " + ch.GetType());
            
        }
    }
}
