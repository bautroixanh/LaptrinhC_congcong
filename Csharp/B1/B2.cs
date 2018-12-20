using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class B2
    {
        public int a { set; get; }
        public int b { set; get; }
        public B2()
        {
            a = 0;
            b = 0;
        }
        public B2(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void tong()
        {
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
        }
        public void nhap()
        {
            this.a = int.Parse(Console.ReadLine());
            this.b = int.Parse(Console.ReadLine());
        }     
    }
}