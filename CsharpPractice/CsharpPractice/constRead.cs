using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//const → compile-time constant, must be initialized at declaration, cannot change later.

//readonly → runtime constant, can be initialized at declaration or constructor, but not elsewhere.

//static → one copy shared across all objects.

namespace CsharpPractice
{
 
    internal class constRead
    {
        static int x;
        public const int y = 10;       // const → compile-time fixed
        public readonly int d;         // readonly → runtime fixed

        // Constructor to assign readonly
        public constRead()
        {
            
                // ✅ allowed
        }

        static void Main()
        {
            Console.WriteLine(y);      // ✅ prints 10

            constRead obj = new constRead();
            Console.WriteLine(obj.d);  // ✅ prints 100
        }
    }
}
