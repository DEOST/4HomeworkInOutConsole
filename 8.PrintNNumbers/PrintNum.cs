//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.PrintNNumbers
{
    class PrintNum
    {
        static void Main()
        {
            Console.Write("Write a n numbers \n n= ");
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("number: {0}", i + 1);
            }
        }
    }
}
