using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program Finding the Longest Word in a Sentence: ");
            Console.WriteLine();
            Console.WriteLine("Please enther the Sentence: for checking:");
            string sent = Console.ReadLine();
            string[] words = sent.Split(' ');
            int lengt = 0;
            string longword = "";
            foreach(string word in words ){


                if (word.Length > lengt)
                {
                    longword = word;
                    lengt = word.Length;
                }
            }
            Console.WriteLine("The longist word is => " + longword);
        }
    }
}
