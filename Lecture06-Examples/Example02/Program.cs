using EasyMathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector[] vectors = Vector.Generate(3, -20, 20);

            Console.WriteLine("排序前:");
            foreach (Vector v in vectors)
                v.Print();

            Console.Write("請選擇排序欄位: (1) X, (2) Y, (3) Length");
            Vector.OrderByField = (OrderBy)int.Parse(Console.ReadLine());
            Array.Sort(vectors);

            Console.WriteLine("排序後:");
            foreach (Vector v in vectors)
                v.Print();
        }
    }
}