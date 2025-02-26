using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program  Sum of Digits");
            Console.WriteLine("Please enther the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            if (num < 0)
            {
                Console.WriteLine("You are input the negativ number");    
            }
            else if(num < 10)
            {
                Console.WriteLine(num);
            }
            else
            {
                while(num != 0)              
                {
                    sum += num % 10;
                    num = num / 10;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
