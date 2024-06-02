using System;

namespace TriangleTypeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lengths of the three sides of the triangle:");

            // Read and parse the sides of the triangle
            double side1 = ReadSide("Side 1: ");
            double side2 = ReadSide("Side 2: ");
            double side3 = ReadSide("Side 3: ");

            // Determine and display the type of the triangle
            string triangleType = DetermineTriangleType(side1, side2, side3);
            Console.WriteLine($"The triangle is {triangleType}");
        }

        static double ReadSide(string prompt)
        {
            double side;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out side) && side > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
            return side;
        }

        static string DetermineTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}
