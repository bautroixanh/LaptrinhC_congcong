using System;
using System.IO;

/// <summary>
/// Summary description for Class1
/// </summary>
public class people
{
    public int id { set; get; }
    public string ten { set; get; }
    public int tuoi { set; get; }
    public string quequan { set; get; }
    public DateTime ngaysinh { set; get; }
    public string nghe { set; get; }
    public people()
    {
        id = 0;
        ten = "";
        tuoi = 0;      
        quequan = "";
        ngaysinh = new DateTime();
        nghe = "";
    }
    public people(int id,string ten, int tuoi, string quequan, DateTime ngaysinh, string nghe)
    {
        this.id = id;
        this.ten = ten;
        this.tuoi = tuoi;
        this.quequan = quequan;
        this.ngaysinh = ngaysinh;
        this.nghe = nghe;
    }
    public void nhap()
    {
        Console.Write("Nhap ID: ");
        this.id = int.Parse(Console.ReadLine());
        Console.Write("Nhap ten: ");
        this.ten = Console.ReadLine();
        Console.Write("Nhap tuoi: ");
        this.tuoi = int.Parse(Console.ReadLine());
       /* Console.Write("Nhap quequan: ");
        this.quequan = Console.ReadLine();
        Console.Write("Nhap ngaysinh: ");
        this.ngaysinh = DateTime.Parse(Console.ReadLine());
        Console.Write("Nhap nghe: ");
        this.nghe = Console.ReadLine();*/
    }
    public void xuat()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Ten: " + ten);
        Console.WriteLine("Tuoi: " + tuoi);
       /* Console.WriteLine("quequan: " + quequan);
        Console.WriteLine("ngaysinh: " + ngaysinh);
        Console.WriteLine("nghe: " + nghe);*/
    }
    public class mang
    {
        public void nhapmangxuat()
        {
            int n;
            people[] a = new people[100];
            Console.WriteLine("Nhap so luong nguoi:");
            n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Nhap Nguoi thu {0}:", i + 1);
                people b = new people();
                b.nhap();
                a[i] = b;
                Console.WriteLine();
            }
            Console.WriteLine("**--------------in ket qua-------------**");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nguoi thu {0}", i + 1);
                Console.WriteLine("Nguoi thu {0}", a[i]);
                a[i].xuat();
                Console.WriteLine();
            }
        }
    }
}