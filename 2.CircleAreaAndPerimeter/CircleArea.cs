//Write a program that reads the radius r of a circle and prints its perimeter and area.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CircleAreaAndPerimeter
{
    class CircleArea
    {
        static void Main()
        {
            Console.WriteLine("Type a radius");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("The perimeter of the circle is {0} and the area is {1}", (Math.PI*2*radius), (Math.PI*radius*radius));
        }
    }
}
