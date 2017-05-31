using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            string sql =
                @"select * from Table
                    where id > 10    
                ";
            Console.WriteLine(sql);

            string path = @"C:\Users\user\Desktop\20170526\Lecture02-Examples";
        }
    }
}
