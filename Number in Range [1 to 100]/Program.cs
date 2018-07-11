using System;

namespace Number_in_Range__1_to_100_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter a number in the range [1...100]: ");
            var n = double.Parse(Console.ReadLine());

            if (n <= 100 && n >= 1)
            {
                Console.WriteLine($"The number is: {n}");
            }

            while (n > 100 || n < 1) 
            {
                Console.WriteLine($"Invalid number!");
                Console.Write($"Enter a number in the range [1...100]: ");
                n = double.Parse(Console.ReadLine());

                if (n <= 100 && n >= 1)
                {
                    Console.WriteLine($"The number is: {n}");
                }
            }
            

            
        }
    }
}
