using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_2
{
    internal class PhanSo : IComparable<PhanSo>
    {
        int TuSo;
        int MauSo;
        public int CompareTo(PhanSo other)
        {
            float a = this.TuSo;
            float b = other.TuSo;
            float c = this.MauSo;
            float d = other.MauSo;
            return (a*d).CompareTo(b*c);
        }
        public PhanSo()
        {
            this.TuSo = 0;
        }
        public int Tu
        {
            get { return this.TuSo; }
            set { this.TuSo = value; }
        }
        public int Mau
        {
            get { return this.MauSo; }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Mau so phai khac 0 !");
                }
                else
                {
                    this.MauSo = value;
                }
            }
        }
        public float DangSoThuc()
        {
            float a = this.Tu;
            float b = this.Mau;
            float x = a/b;
            return x;
        }
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.Tu = a.Tu * b.Mau + b.Tu * a.Mau;
            c.Mau = a.Mau * b.Mau;
            c.RutGon();
            return c;
        }
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.Tu = a.Tu * b.Mau - b.Tu * a.Mau;
            c.Mau = a.Mau * b.Mau;
            c.RutGon();
            return c;
        }
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.Tu = a.Tu * b.Tu;
            c.Mau = a.Mau * b.Mau;
            c.RutGon();
            return c;
        }
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.Tu = a.Tu * b.Mau;
            c.Mau = a.Mau * b.Tu;
            c.RutGon();
            return c;
        }
        public static bool operator ==(PhanSo a, PhanSo b)
        {
            if(a.Tu*b.Mau == b.Tu*a.Mau) return true;
            else return false;
        }
        public static bool operator !=(PhanSo a, PhanSo b)
        {
            if (a.Tu * b.Mau != b.Tu * a.Mau) return true;
            else return false;
        }
        public static bool operator >(PhanSo a, PhanSo b)
        {
            if (a.Tu * b.Mau > b.Tu * a.Mau) return true;
            else return false;
        }
        public static bool operator <(PhanSo a, PhanSo b)
        {
            if (a.Tu * b.Mau < b.Tu * a.Mau) return true;
            else return false;
        }
        public void RutGon()
        {
            int TS = this.Tu;
            int MS = this.Mau;
            int UCLN;
            if (TS < 0) { TS = TS * -1; }
            if (MS < 0) { MS = MS * -1; }
            if (TS == 0)
            {
                return;
            }
            while (TS != MS)
            {
                if (TS > MS) { TS -= MS; }
                else MS -= TS;
            }
            UCLN = TS;
            this.Mau /= UCLN;
            this.Tu /= UCLN;
        }
        public override string ToString()
        {
            return this.Tu.ToString() + "/" + this.Mau.ToString();
        }
        public void NhapPhanso()
        {
            Console.Write("Tu so = ");
            this.Tu = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Mau so = ");
                this.Mau = int.Parse(Console.ReadLine());
            }
            while (this.Mau == 0);
        }
        public void InPhanso()
        {
            Console.Write("Phan so vua nhap la: " + this.Tu + "/" + this.Mau + "\n");
        }
        public void InPhanSoKQ()
        {
            Console.Write("Ket qua la: " + this.Tu + "/" + this.Mau + "\n");
        }
    }
}
