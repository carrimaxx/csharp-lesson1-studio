using System;

namespace Class1Studio
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a radius:");
            string inputRadius = Console.ReadLine();
            double radius = double.Parse(inputRadius); 

            while (radius < 0)
            {
                Console.WriteLine("Enter a positive number for the radius:");
                inputRadius = Console.ReadLine();
                radius = double.Parse(inputRadius);
            }

            Console.WriteLine($"The area of a circle of radius {radius} is : {Math.PI * radius * radius}");
            Console.WriteLine($"The circumference of radius {radius} is: {2 * Math.PI * radius}");
            Console.WriteLine($"The diameter of the circle is: {2 * radius}");

            Console.WriteLine("Enter your car's miles per gallon:");
            string inputMpg = Console.ReadLine();
            double mpg = double.Parse(inputMpg);
            Console.WriteLine($"Your car's mpg is {mpg}mpg.");

            double gallons = (2 * Math.PI * radius) / mpg;
            Console.WriteLine($"\nYour car will use {gallons} gallons of gas to go around a circle.");
        }
    }

}
