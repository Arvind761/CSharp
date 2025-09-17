using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    public class Box<T>
    {
        private T _value;
        public void SetValue(T Value)
        {
            _value=Value;
        }
        public T GetValue()
        {
            return _value;
        }

    }
    public class Math<T> {
        public T MathFun(T? V1, T? V2) { 
        
            dynamic d1= V1;
            dynamic d2= V2;
            dynamic res = d1 + d2;
            return res;
        }
    
    }

    public class Generic
    {
        public static void Main(string[] args) { 
            Math<int> addInt=new Math<int>();
            Console.WriteLine(addInt.MathFun(10, 20));
            Math<string> addString = new Math<string>();
            Console.WriteLine(addString.MathFun("Radha", "Rani"));

            //Box<int> box = new Box<int>();
            //box.SetValue(42);
            //Console.WriteLine(box.GetValue());
            //Box<string> box2 = new Box<string>();
            //box2.SetValue("Arvind");
            //Console.WriteLine(box2.GetValue());
            //Box<double> box3 = new Box<double>();
            //box3.SetValue(420.56);
            //Console.WriteLine(box3.GetValue());
            //Box<bool> box4 = new Box<bool>();
            //box4.SetValue(true);
            //Console.WriteLine(box4.GetValue());
        } 


    }
}
