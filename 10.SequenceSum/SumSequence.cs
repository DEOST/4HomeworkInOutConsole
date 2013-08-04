//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SequenceSum
{
    class SumSequence
    {
        static void Main()
        {
            double i=2;
            double sum=1;
            for (i = 2; i <1000; i++)
            {
                if (i % 2 ==0)
                {
                    sum += 1 / i;
                }
                else
                {
                    sum+=-1/i;
                }
            }
            Console.WriteLine("the sum is {0} ", sum, i);
        }
    }
}
