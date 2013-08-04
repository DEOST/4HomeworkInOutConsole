//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.NumberBetween
{
    class NumberBetween
    {
        static void Main()
        {
            Console.WriteLine("type first number");
            uint firstNumber = uint.Parse(Console.ReadLine());
            Console.WriteLine("type second number");
            uint secondNumber = uint.Parse(Console.ReadLine());
            int k=0;
            if (firstNumber %  5 == 0)
            { 
                k = 1;
            }
            else if (secondNumber % 5 == 0)
            {
                k++;
            }
            long p = Math.Abs(secondNumber-firstNumber)/5+k;
            Console.WriteLine("p({0},{1}) = {2}", firstNumber, secondNumber, p);
        }
    }
}
