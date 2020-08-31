using System;

namespace Studio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Radius: ");
            double radius = double.Parse(Console.ReadLine());

            double area = Math.Round(Math.PI * Math.Pow(radius, 2), 3);
            Console.WriteLine("The area is of a circle with a raius of " + radius + " is: " + area);

            double circumference = Math.Round(2 * Math.PI * radius, 3);
            double diameter = Math.Round(2 * radius, 3);

            Console.WriteLine("The circumference is: " + circumference);
            Console.WriteLine("The diameter is: " + diameter);
        }
    }
}
