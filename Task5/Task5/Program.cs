﻿
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program checking the number is Prime or not");
            Console.WriteLine();
            Console.WriteLine("Please enther the number for checking");
            int num = int.Parse(Console.ReadLine());
            

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("The number is not a prime:");
                        break;
             
                    }
                    else
                    {
                        Console.WriteLine("The number is prime:");
                        break;
                    }
                }
            
        }
    }
}
