using System;

namespace OddorEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, remainder;
            Console.WriteLine("Please enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            remainder = number % 2;

            if (remainder == 0)
            {
                Console.WriteLine("{0} is an Even number", number);
            }
            else
            {
                Console.WriteLine("{0} is an Odd number", number);
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }

        }
    }
}
