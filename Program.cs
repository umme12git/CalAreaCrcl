using System;

namespace CalAreaCrcl
{
    class Program
    {
        public static double AreaOfCircle(double radius)
        {
            
            return (Math.PI * radius * radius);

        }


        static void Main(string[] args)
        {
            double radius;
            double AreaCir;

            Console.WriteLine("What is the radius of the circle?");
            radius = double.Parse(Console.ReadLine());
            AreaCir = AreaOfCircle(radius);

            Console.WriteLine($"The area of the circle is {AreaCir}");

        }

    }
}

                