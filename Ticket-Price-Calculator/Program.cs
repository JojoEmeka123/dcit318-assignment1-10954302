using System;

namespace MovieTicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();
            int age;

            if (int.TryParse(input, out age))
            {
                int ticketPrice = CalculateTicketPrice(age);
                Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }

        static int CalculateTicketPrice(int age)
        {
            const int regularPrice = 10;
            const int discountedPrice = 7;

            if (age <= 12 || age >= 65)
            {
                return discountedPrice;
            }
            else
            {
                return regularPrice;
            }
        }
    }
}

