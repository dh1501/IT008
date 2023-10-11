using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_1
{
    internal class Program
    {
        static Rectangle[] R;
        static int indexR = 0;
        static Square[] S;
        static int indexS = 0;
        static Circle[] C;
        static int indexC = 0;
        static Triangle[] T;
        static int indexT = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("IT008_LAB1\nBai tap 1.1: ");
            Console.WriteLine("Nhap so luong hinh can tao: ");



            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string t;
                Random rd = new Random();
                t = rd.Next(0, 3).ToString();

                switch (t)
                {
                    case "0": //Rectangle
                        CreateRectangle();
                        break;

                    case "1": //Square
                        CreateSquare();
                        break;

                    case "2": //Circle
                        CreateCircle();
                        break;

                    case "3": //Triangle
                        CreateTriangle();
                        break;

                }
            }
        }
        static void CreateRectangle()
            {
                int x0, y0;
                double length, width;


                Console.WriteLine("Create Rectangle " + indexR);
                indexR = indexR + 1;

                Console.WriteLine("Enter the location (x;y): ");
                x0 = int.Parse(Console.ReadLine());
                y0 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter length and width: ");
                length = double.Parse(Console.ReadLine());
                width = double.Parse(Console.ReadLine());

                R[indexR] = new Rectangle(x0, y0, width, length);


                Console.WriteLine("--Created--\n");
            }
        static void CreateSquare()
        {
            int x1, y1;
            double side;


            Console.WriteLine("Create Square " + indexS);
            indexS = indexS + 1;

            Console.WriteLine("Enter the location (x;y): ");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter side: ");
            side = double.Parse(Console.ReadLine());

            S[indexS] = new Square(x1, y1, side);


            Console.WriteLine("--Created--\n");
        }
        static void CreateTriangle()
        {
            int x3, y3;
            double a, b, c;


            Console.WriteLine("Create Triangle " + indexT);
            indexT = indexT + 1;

            Console.WriteLine("Enter the location (x;y): ");
            x3 = int.Parse(Console.ReadLine());
            y3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 3 edge a, b, c: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            T[indexT] = new Triangle(x3, y3, a, b, c);


            Console.WriteLine("--Created--\n");
        }
        static void CreateCircle()
        {
            int x2, y2;
            double radius;


            Console.WriteLine("Create Circle " + indexC);
            indexC = indexC + 1;

            Console.WriteLine("Enter the location (x;y): ");
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter radius: ");
            radius = double.Parse(Console.ReadLine());

            C[indexC] = new Circle(x2, y2, radius);


            Console.WriteLine("--Created--\n");
        }

    
    }
}
