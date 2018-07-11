using System;
using System.Linq;

namespace pairs_by_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            Result(input, difference);
        }

        private static void Result(int[] input, int difference)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int a = i + 1; a < input.Length; a++)
                {
                    if ( Math.Abs(input[i] - input[a]) == difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
