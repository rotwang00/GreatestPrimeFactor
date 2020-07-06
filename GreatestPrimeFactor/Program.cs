using System;
using System.Net.Http.Headers;

namespace GreatestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer to find the greatest prime factor: ");
            string stringInput = Console.ReadLine();

            int input = int.Parse(stringInput);

            int working = input;

            int answer = 1;

            // Take care of twos
            while (working % 2 == 0)
            {
                answer = 2;
                working /= 2;
            }

            int ceiling = (int)Math.Floor(Math.Sqrt(input));

            // Number is now odd. Just check odd factors.
            for (int i = 3; i <= ceiling; i = i + 2)
            {
                while (working % i == 0)
                {
                    answer = i;
                    working /= i;
                }
            }

            if (working == input)
            {
                answer = input;
            }

            Console.WriteLine($"The greatest prime factor of {input} is {answer}");
        }
    }
}
