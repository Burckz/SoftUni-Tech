using System;
using System.Linq;

namespace most_frequent_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Result(input);
        }

        private static void Result (int[] input)
        {
            int len = 1;
            int result = 0;
            int bestLen = len;

            for (int i = 0; i < input.Length; i++)
            {
                for (int a = 0; a < input.Length; a++)
                {
                    if (input[i] == input[a])
                    {
                        len++;
                            if(len > bestLen)
                        {
                            bestLen = len;
                            result = input[i];
                        }
                    }
                    else
                    {
                        len = 1;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
