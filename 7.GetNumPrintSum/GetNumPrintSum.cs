//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.GetNumPrintSum
{
    class GetNumPrintSum
    {
        static void Main()
        {
             int sum = 0;
             Console.Write("Write a n numbers \n n= ");
             int n = int.Parse(Console.ReadLine());
             for (int i = 0; i < n; i++)
             {
                 Console.WriteLine("Type number: ");
                 int bufer = int.Parse(Console.ReadLine());
                 sum = sum + bufer;
             }
             Console.WriteLine("The sum is {0}", sum);
        }
    }
}
