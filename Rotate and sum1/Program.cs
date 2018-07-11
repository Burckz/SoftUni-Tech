using System;
using System.Linq;

namespace Rotate_and_sum1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sum = new int[inputArray.Length];

            int rotations = int.Parse(Console.ReadLine());

            for (int i=0; i < rotations; i++)
            {
                int[] rotated = new int[inputArray.Length];
                rotated[0] = inputArray[inputArray.Length - 1];
                for (int c = 1; c < inputArray.Length; c++)
                {
                    rotated[c] = inputArray[c - 1];
                }

                for (int b = 0; b<sum.Length; b++)
                {
                    sum[b] = sum[b] + rotated[b];
                }

                inputArray = rotated;
            }

            Console.WriteLine(string.Join(" ",sum));
        }
        
    }
}
