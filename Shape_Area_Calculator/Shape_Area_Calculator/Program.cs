using System;

namespace Shape_Area_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key;
            Console.WriteLine("What shape would you like to find the area of?");
            Console.WriteLine("Please enter 'r' for rectangle or any other key for circle:");
            key = Console.ReadLine();

            float result;
            if (key == "r")
            {
                Console.WriteLine("Please enter the height: ");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width: ");
                float width = float.Parse(Console.ReadLine());

                result = height * width;
                Console.WriteLine($"The area of the rectangle is: {result}");
            }
            else
            {
                Console.WriteLine("Please enter the radius: ");
                float radius = float.Parse(Console.ReadLine());

                result = (float)(Math.PI * radius * radius);
                Console.WriteLine($"The area of the circle is: {result}");
            }
        }
    }
}
