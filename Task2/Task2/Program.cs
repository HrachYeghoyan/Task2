using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the number");
            int num = int.Parse(Console.ReadLine());
            int revers = 0;
            if(num < 10)
            {
                Console.WriteLine(num);
            }
            else if(num < 0) 
            {
                Console.WriteLine("You are input the negativ number:");
            }
            else
            {
                while (num != 0)
                {
                    int res = num % 10;
                    revers = (revers * 10) + res;
                    num = num / 10;
                }
                Console.WriteLine(revers);
            }
            
            Console.WriteLine();

        }
    }
}
