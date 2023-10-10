namespace Bai1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhanSo a = new PhanSo();
            PhanSo b = new PhanSo();
            PhanSo c = new PhanSo();
            Console.WriteLine("Nhap phan so thu nhat: ");
            a.NhapPhanso();
            a.InPhanso();
            Console.WriteLine("Phan so thu nhat o dang so thuc la: " + a.DangSoThuc());
            Console.WriteLine("Nhap phan so thu hai: ");
            b.NhapPhanso();
            b.InPhanso();
            Console.WriteLine("Phan so thu nhat o dang so thuc la: " + b.DangSoThuc());
            c = a + b;
            Console.WriteLine("a + b = ");
            c.InPhanSoKQ();
            c = a - b;
            Console.WriteLine("a - b = ");
            c.InPhanSoKQ();
            c = a * b;
            Console.WriteLine("a * b = ");
            c.InPhanSoKQ();
            c = a / b;
            Console.WriteLine("a / b = ");
            c.InPhanSoKQ();
            if (a==b) Console.WriteLine("Phan so a bang phan so b");    
            if (a!=b) Console.WriteLine("Phan so a khac phan so b");
            if (a>b)  Console.WriteLine("Phan so a lon hon phan so b");
            if (a<b)  Console.WriteLine("Phan so a be hon phan so b");
            List<PhanSo> Array = new List<PhanSo>(3);
            Array.Add(a);
            Array.Add(b);
            Array.Add(c);
            Array.Sort();
            for (int i = 0; i < Array.Count; i++)
            {
                Console.WriteLine(Array[i]);
            }    
        }
    }
}