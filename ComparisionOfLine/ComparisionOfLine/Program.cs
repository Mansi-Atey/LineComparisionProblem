﻿using System;

namespace ComparisionOfLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, x3, x4, y1, y2, y3, y4;
            Console.WriteLine("Enter values for x1 and y1");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values for x2 and y2");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values for x3 and y3 of line 2");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values for x4 and y4 of line 2");
            x4 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());
            double line1 = (Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2));
            double line2 = (Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2));
            int difference = line1.CompareTo(line2);
             if (difference == 0)
            {
                Console.WriteLine("The lines are equal in length");
            }
             else if (difference > 0)
            {
                Console.WriteLine("The first line is greater in length than second line");
            }
            else
            {
                Console.WriteLine("The first line is smaller in length than second line");
            }
        }
    }
}
