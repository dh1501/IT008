using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Bai1_4
    {
        public static void Main(string[] args)
        {
            NhietKe t = new NhietKe();
            Random rnd = new Random();

            t.TempChanged += _TempChanged;

            for (int i = 0; i < 20; i++)
            {
                t.Temprature = Math.Round((rnd.NextDouble() + rnd.Next(-80, 80)), 2);
            }

        }

        private static void _TempChanged (object? sender, TempratureChangedArr n)
        {
            Console.WriteLine("Cap nhat nhiet do: " + n.TempratureEV);
        }
    }

}