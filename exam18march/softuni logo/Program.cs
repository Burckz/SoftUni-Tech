using System;

namespace softuni_logo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numberOfDots = ((12 * n) - 5) / 2;
            var numberOfDiez = 1;

            if (n >= 2 && n <= 50)
            {
                for ( int row = 0; row < n * 2; row++)
                {
                    for (int sideA = 0; sideA < numberOfDots; sideA++)
                    {
                        Console.Write(".");
                    }

                    
                    for (int diez = 0; diez < numberOfDiez; diez++)
                    {
                        Console.Write("#");
                    }

                    for (int diez = 1; diez < numberOfDiez; diez++)
                    {
                        Console.Write("#");
                    }

                    for (int sideB = numberOfDots; sideB > 0; sideB--)
                    {
                        Console.Write(".");
                    }

                    
                    numberOfDiez = numberOfDiez + 3;
                    numberOfDots = numberOfDots - 3;
                    Console.WriteLine();   
                }


            }
        }
    }
}
