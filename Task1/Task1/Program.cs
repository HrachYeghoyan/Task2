using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is Fibonacci Sequence Generator");
            Console.WriteLine("Please enther the number:");
            int number = int.Parse(Console.ReadLine());
            if(number < 0)
            {
                Console.WriteLine("Please enther the positiv number:");
                return;
            }
            int num1 = 0;
            int num2 = 1;
            int temp;
            if(number >= 1)
            {
                Console.WriteLine(num1 + " ");
            }
            for(int i = 2; i <= number; i++)
            {
                Console.WriteLine(num2 + " ");
                temp = num2;
                num2 = num1 + num2;
                num1 = temp;
            }
            Console.WriteLine();
        }
    }
}
