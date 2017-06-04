using EasyMathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RandomGenerator random = new RandomGenerator();
            Console.WriteLine(random.NextDouble(3.1, 5.5));
            Console.WriteLine(random.NextDouble());
        }
    }
}