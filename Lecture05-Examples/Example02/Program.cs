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
            Vector[] vectors = new Vector[]
            {
                new Vector(),
                new Vector(3,4)
            };

            for (int index = 0; index < vectors.Length; index++)
                vectors[index].Print();

            foreach (Vector v in vectors)
                v.Print();
        }
    }
}