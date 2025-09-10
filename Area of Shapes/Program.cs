using System;
class Program
{
    static double RectangleArea(double length, double width)
    {
        return length * width;
    }

    static double CircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    static double TriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }
    static double GetPositiveDouble(string message)
    {
        double value;
        Console.Write(message);
        while (!double.TryParse(Console.ReadLine(), out value) || value <= 0)
        {
            Console.Write("Invalid input, please enter a positive number: ");
        }
        return value;
    }
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter the shape you want to calculate its area:");
            Console.WriteLine("(1) Rectangle");
            Console.WriteLine("(2) Circle");
            Console.WriteLine("(3) Triangle");
            Console.Write("Enter your choice: ");

            int num;
            while (!int.TryParse(Console.ReadLine(), out num) || num < 1 || num > 3)
            {
                Console.Write("Invalid input, please enter 1, 2, or 3: ");
            }

            if (num == 1)
            {
                double length = GetPositiveDouble("Enter the length: ");
                double width = GetPositiveDouble("Enter the width: ");
                Console.WriteLine("Area = " + RectangleArea(length, width));
            }
            else if (num == 2)
            {
                double radius = GetPositiveDouble("Enter the radius: ");
                Console.WriteLine("Area = " + CircleArea(radius));
            }
            else if (num == 3)
            {
                double baseLength = GetPositiveDouble("Enter the base: ");
                double height = GetPositiveDouble("Enter the height: ");
                Console.WriteLine("Area = " + TriangleArea(baseLength, height));
            }

            Console.Write("Do you want to calculate the area of another shape? (Yes/No): ");
            string choice = Console.ReadLine().Trim().ToLower();
            if (choice == "no" || choice == "n")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else if (choice == "yes" || choice == "y")
            {
                Console.WriteLine("Okay!");
            }
            else
            {
                Console.WriteLine("Invalid input! Exiting program.");
                break;
            }
        }
    }
}
