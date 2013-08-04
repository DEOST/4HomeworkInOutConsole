//Write a program that reads 3 integer numbers from the console and prints their sum.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4HomeworkInOutConsole
{
    class SumOfThree
    {
        static void Main()
        {
            Console.WriteLine("type first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("type second number");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("type third number");
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of first, second and third is "+ (firstNumber+secondNumber+thirdNumber));
        }
    }
}
