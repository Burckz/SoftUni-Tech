using System;
using System.Linq;

namespace equal_sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Result(input);
        }

        private static void Result(int[] input)
        {
            
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < input.Length; i++)
            {
                
                    for (int a = 0; a < i; a++)
                    {
                        sumLeft = sumLeft + input[a];
                    }
                    for (int b = i + 1; b < input.Length; b++)
                    {
                        sumRight = sumRight + input[b];
                    }


                    if (sumLeft == sumRight)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                    else
                    {
                        sumLeft = 0;
                        sumRight = 0;
                    }

                    if(i == input.Length - 1)
                    {
                        Console.WriteLine("no");
                    }
                
            }
        }
    }
}
