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
            Console.WriteLine("請輸入學生數量:");
            int studentCount = int.Parse(Console.ReadLine());

            Scores[] scores = Scores.Generate(studentCount, 40, 100);
            Console.WriteLine("排序前:");
            foreach (Scores s in scores)
                s.Print();

            Console.Write("請選擇排序欄位: (0)國文, (1)英文, (2)數學, (3)總分");
            Scores.SortByField = (SortBy)int.Parse(Console.ReadLine());
            Array.Sort(scores);

            Console.WriteLine("排序後:");
            foreach (Scores s in scores)
                s.Print();
        }
    }
}