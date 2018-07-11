using System;
using System.Linq;

namespace max_sequence_of_increasing_elements
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
            int len = 1;
            int start = 0;
            int bestLen = len;
            int bestStart = start;
            int pos = 1;
            int count = 0;

            for (int i = pos; i < input.Length; i++)
            {
                
                if (input[i-1] < input[i])
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestStart = start;
                    }
                }
                else
                {
                    len = 1;
                    start = i;
                }
            }

            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write($"{input[i]} ");
            }
            Console.WriteLine();
        }
    }
}
