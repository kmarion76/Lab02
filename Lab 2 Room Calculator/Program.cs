using System;

namespace Lab_2_Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            double length, width, area, perimeter;
            string userResponse;
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator");
            Console.WriteLine("");
            do
            {
                Console.Write("Enter Length: ");
                length = double.Parse(Console.ReadLine());

                Console.Write("Enter Width: ");
                width = double.Parse(Console.ReadLine());

                area = length * width;
                perimeter = (2 * length) + (2 * width);

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);

                Console.WriteLine("");

                Console.Write("Continue? (y/n): ");
                userResponse = Console.ReadLine();

            } while (userResponse == "y" || userResponse == "Y");

        }
    }
}
