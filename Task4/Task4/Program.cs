using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is doing Multiplication Table");
            Console.WriteLine();
            Console.WriteLine("Please enther the number which Multiplication tabel you wnat:" );
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " * " + num  + " = " + i * num);
            }
           
        }
    }
}
