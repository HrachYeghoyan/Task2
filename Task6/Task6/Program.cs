using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program doing Collatz Conjecture");
            Console.WriteLine();
            Console.WriteLine("Please enther the number: ");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            while(num != 1)
            {
                if(num %2  != 0)
                {
                    num = num * 3 + 1;
                }
                else
                {
                    num = num / 2;
                }
                count++;
            }
            Console.WriteLine("The result is " + count);
        }
    }
}
