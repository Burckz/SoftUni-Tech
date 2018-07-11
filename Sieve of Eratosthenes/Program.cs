using System;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            IsPrime(n);
        }

        static void IsPrime (int n)
        {
            int[] array = new int[n];
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                
              
                array[i] = i + 1;

            }
            

            for (int arrayNum = 0; array[arrayNum] < n; arrayNum++)
            {
                counter = 0;

                for (int i = 2; i <= array[arrayNum]/2; i++)
                {
                    if(array[arrayNum] % i == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && array[arrayNum] != 1)
                {
                    Console.Write($"{array[arrayNum]} ");
                }

                
            }
            Console.WriteLine();
        }
    }
}
