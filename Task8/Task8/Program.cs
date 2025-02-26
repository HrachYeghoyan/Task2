using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string a = "AghSDWEKxa&@$#sASsas12131&^&&%*";
            Console.WriteLine("Please enther the count of pasword");
            int count = int.Parse(Console.ReadLine());
            var arr = new char[count];
            Console.WriteLine("Please enter  P for generate pasword and X for exit");
            char x = char.Parse(Console.ReadLine());
            if (x == 'P')
            {
                for (int i = 0; i < count; i++)
                {
                    arr[i] = a[rnd.Next(a.Length)];
                }
            }
            else
            {
                Console.WriteLine("Program Exited");
                return;
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
