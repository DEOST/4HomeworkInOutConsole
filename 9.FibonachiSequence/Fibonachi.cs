//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.FibonachiSequence
{
    class Fibonachi
    {
        static void Main()
        {
            ulong fiboNumber1 = 1u;
            ulong fiboNumber2 = 0u;
            ulong fiboNumber3 = 0u;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(fiboNumber3);
                fiboNumber3 = fiboNumber1+fiboNumber2;
                fiboNumber1 = fiboNumber2;
                fiboNumber2 = fiboNumber3;
            }
        }
    }
}
