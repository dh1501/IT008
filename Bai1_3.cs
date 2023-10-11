using Bai1_3;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        bai1_3 GTLN = new bai1_3();
        Console.Write("Nhap so luong phan tu cua day so nguyen: ");
        int x = int.Parse(Console.ReadLine());
        int[] a = new int[x];
        a = GTLN.nhap(a, x);
        Console.Write("Nhap so luong phan tu cua day so thuc: ");
        int y = int.Parse(Console.ReadLine());
        float[] b = new float[y];
        b = GTLN.nhap(b, y);
        Console.Write("Nhap so luong phan tu cua day chuoi: ");
        int z = int.Parse(Console.ReadLine());
        string[] c = new string[z];
        c = GTLN.nhap(c, z);
        Console.WriteLine("Gia tri lon nhat cua day so nguyen la: " + GTLN.FindMax(a));
        Console.WriteLine("Gia tri be nhat cua day so nguyen la: " + GTLN.FindMin(a));
        Console.WriteLine("Gia tri lon nhat cua day so thuc la: " + GTLN.FindMax(b));
        Console.WriteLine("Gia tri be nhat cua day so thuc la: " + GTLN.FindMin(b));
        Console.WriteLine("Chuoi dai nhat cua day chuoi la: " + GTLN.FindMax(c));
        Console.WriteLine("Chuoi ngan nhat cua day chuoi la: " + GTLN.FindMin(c));
    }
}
