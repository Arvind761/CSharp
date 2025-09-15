using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProjectSir
{
    internal class Constructor
    {
        int i;
        string s;
        bool b;
        //int i = 12;
        //string s="radha";
        //bool b=false;
        public Constructor() {
            i=10;
           s="ae";
           b=false;
            

        }
        public static void Main(string[] args)
        {
            Constructor c = new Constructor();
           
            Console.WriteLine($"int= {c.i} string = {c.s} bool={c.b}");

        }
    }
}
