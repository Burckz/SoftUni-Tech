using System;
using System.Linq;

namespace max_sequence_of_equal_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int len = 1;
            int pos = 1;
            int start = 0;
            int bestStart = start;
            int bestLen = len;

            for (int i = pos; i < inputArray.Length; i++)
            {
                if (inputArray[start] == inputArray[i])
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

            for (int first = bestStart; first <bestStart + bestLen; first++)
            {
                Console.Write($"{inputArray[first]} ");
            }
            Console.WriteLine();
        }

        
    }
}
