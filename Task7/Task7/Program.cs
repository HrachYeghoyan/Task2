using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program make the numbers piramida: ");
            Console.WriteLine();
            Console.WriteLine("Please enther the row for piramida:");
            int row = int.Parse(Console.ReadLine());// burgi toxeri qanaki arjeqavorum 
            for (int i = 1; i <= row; i++)// cikl amen toxi hamar 
            {
                for (int j = 1; j <= i; j++)//tpum e i-n i angam
                {
                    Console.Write(i);
                }
                Console.WriteLine();// vorpesi stacvi burgi tesk tpum e nor tox amen i hat i tpeluc heto
            }
        }
    }
}
