using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
             B2 b2 = new B2();
             Console.WriteLine(b2.a);
             Console.WriteLine(b2.b);
             b2.nhap();
             Console.WriteLine("Van nhap b: "+b2.a);
             b2.tong();
            Console.ReadKey();
        }
    }
}
