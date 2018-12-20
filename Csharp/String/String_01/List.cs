using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace String_01
{
    class List
    {
        List<people> peoples = new List<people>();
        public void list()
        {
            // khoi tao doi tuong moi
            people human = new people();
            // nhap thong tin doi tuong
            human.nhap();
            // them doi tuong vao list
            peoples.Add(human);

            people human2 = new people();

            human2.nhap();

            peoples.Add(human2);

            Console.WriteLine("-Chon 1 de them nguoi \n-Chon 2 de xoa nguoi\n-Chon 3 de sua noi dung");
            //Console.WriteLine("Ban muon them nguoi an Y khong an N:");
            
            String N;
            do
            {
                int c;
                Console.WriteLine("Nhap tuy chon: ");
                c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        people human3 = new people();
                        human3.nhap();
                        peoples.Add(human3);
                        break;
                    case 2:
                        Console.WriteLine("Ban muon xoa vi tri nao: ");
                        int a = int.Parse(Console.ReadLine());
                        int b = a - 1;
                        peoples.RemoveAt(b);
                        break;
                    case 3:
                        Console.WriteLine("");
                        
                        break;
                    default:
                        Console.WriteLine("Default case....");
                        break;
                }
                Console.WriteLine("Tiep tuc chinh sua an Y neu khong an N de thoat");
                N = Console.ReadLine();
            } while (N != "N");

            Console.WriteLine("So phan tu trong LIST: " + peoples.Count);
            foreach (var p in peoples)
            {
                p.xuat();
            }
        }
        //List<int> MyList3 = new List<int>(MyList2);(sao chép phần tử sang list mới)
    }
}