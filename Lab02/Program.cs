using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator");
            Console.WriteLine(" ");


            double length, width, area, perimeter;
            string userAnswer;

            do
            {
                Console.WriteLine("Enter Length: ");
                length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width: ");
                width = double.Parse(Console.ReadLine());
                area = length * width;
                perimeter = (2 * length) + (2 * width);
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Preimeter: " + perimeter);
                Console.WriteLine(" ");
                Console.WriteLine("Continue? (y/n:) ");
                userAnswer = Console.ReadLine();


            } while (userAnswer == "y" || userAnswer == "Y");

        }
    }
}
