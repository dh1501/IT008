using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_3
{
    class bai1_3
    {
        public int[] nhap(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        public float[] nhap(float[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                a[i] = float.Parse(Console.ReadLine());
            }
            return a;
        }
        public string[] nhap(string[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                a[i] = Console.ReadLine();
            }
            return a;
        }
        public int FindMax (int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
                return max;
        }
        public int FindMin(int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }
        public float FindMin(float[] a)
        {
            float min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }
        public float FindMax(float[] a)
        {
            float max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        public string FindMin(string[] a)
        {
            string min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length < min.Length)
                {
                    min = a[i];
                }
            }
            return min;
        }
        public string FindMax(string[] a)
        {
            string max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length > max.Length)
                {
                    max = a[i];
                }
            }
            return max;
        }
    }
}
