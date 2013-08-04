using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please write a number:");
            int num = int.Parse(Console.ReadLine());
            int k = 1;
            for (k = 1; k < num; ) ;
            {
                for (int i = 1; i < (Math.Sqrt(num)); )
                    if (k % i == 0)
                    {
                        i++;
                        k++;
                    }
                    else Console.WriteLine(k);
            }
        }
    }
}
