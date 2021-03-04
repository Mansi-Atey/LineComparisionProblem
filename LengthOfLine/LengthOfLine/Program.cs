using System;

namespace LengthOfLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            Console.WriteLine("Enter values for x1 and y1");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values for x2 and y2");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            double lineLength = (Math.Sqrt((x2 - x1)^2 + (y2 - y1)^2));
            Console.WriteLine("The length of line is:" + lineLength);
        }
    }
}
