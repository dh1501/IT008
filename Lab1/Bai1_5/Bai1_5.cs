using System;
using System.IO;
namespace Lab1
{
    internal class Bai1_5
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap duong dan thu muc: ");
            string PathFolder = Console.ReadLine();

            DirectoryInfo direct = new DirectoryInfo(PathFolder);
            if (!direct.Exists)
            {
                Console.WriteLine("Thu muc khong ton tai!");
                return;
            }
            foreach (FileInfo file in direct.GetFiles())
            {
                Console.WriteLine(file.Name);
            }
        }
    }
}
