using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class B3
    {
        public void nhap()
        {
            string fullname;
            fullname = Console.ReadLine();
            Console.WriteLine("Fullname "+  fullname);
        }
        public void PassWord()
        {
            string user,password;
            Console.Write("Kiem tra dang nhap");
            do
            {
                Console.Write("Ten dang nhap: ");
                user = Console.ReadLine();
                Console.Write("Mat khau: ");
                password = Console.ReadLine();
            }
            while (user != "user" && password != "password");
            Console.WriteLine("Ten dang nhap va mat khau dung!");
            Console.ReadKey();
        }
        public void mang()
        {
            int n;
            int[] IntArray = new int[10];
            int Sum = 0;
            Console.Write("Nhap N: ");
            n = int.Parse(Console.ReadLine());

            for (int i=0;i<n;i++)
            {
               IntArray[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<n;i++)
            {
                Sum += IntArray[i];
            }
            /*foreach (int item in IntArray)
                {
                    // Console.Write("\t" +item);
                    Sum += item;
                }*/
            Console.Write("Tong" + Sum);
        }
    }
}