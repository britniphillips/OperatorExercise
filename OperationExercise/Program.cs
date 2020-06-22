using System;

namespace OperationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 73;
            var b = 27;
            var div = (a / b);
            var mod = (a % b);
            Console.WriteLine($"{a}/{b} is {div} remainder {mod}.");

            var r = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the radius of your circle?");
            var pi = Math.PI;

            var areaOfCircle = CalculateArea(r);

            Console.WriteLine($"The area of a circle with the radius of {r} is {areaOfCircle}");

            //What is the value of "k" in the following code?;
            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine(k);
        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}

