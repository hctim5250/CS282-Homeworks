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
            Empolyee salary = new Empolyee();
            Console.WriteLine("請輸入底薪");
            double basesalary = double.Parse(Console.ReadLine());
            salary.BaseSalary = basesalary;
            Console.WriteLine("請輸入獎金");
            double benefit = double.Parse(Console.ReadLine());
            salary.Benefit = benefit;
            Console.WriteLine("您的薪資總額為{0}", salary.Salary);
        }
    }
}