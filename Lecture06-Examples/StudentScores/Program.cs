using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace StudentScores
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Scores[] scores = Scores.Generate(20, 40, 100);
            Console.WriteLine("排序前:");
            foreach (Scores v in scores)
                v.Print();

            Console.Write("請選擇排序欄位: (1)國文, (2)英文, (3)數學, (4)總分");
            Scores.SortByField = (SortBy)int.Parse(Console.ReadLine());
            Array.Sort(scores);

            Console.WriteLine("排序後:");
            foreach (Scores v in scores)
                v.Print();
        }
    }
}