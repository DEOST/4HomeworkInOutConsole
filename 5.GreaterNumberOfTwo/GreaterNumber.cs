//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.GreaterNumberOfTwo
{
    class GreaterNumber
    {
        static void Main()
        {
            Console.WriteLine("type first number");
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine("type second number");
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            decimal greater = Math.Max(firstNumber, secondNumber);
            Console.WriteLine("The Greater number is {0}",greater);
        }
    }
}
