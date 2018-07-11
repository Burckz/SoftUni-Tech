using System;
using System.Linq;

namespace fold_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(FoldAndSum(input));
        }
        private static string FoldAndSum (string input)
        {
            int[] inputArray = new int[input.Split().Length];
            inputArray = input.Split().Select(int.Parse).ToArray();

            int[] firstRow = new int[inputArray.Length / 2];
            int[] secondRow = new int[inputArray.Length / 2];

            for (int i = 0; i < inputArray.Length/4; i++)
            {
                firstRow[i] = inputArray[inputArray.Length / 4 - 1 - i];
                firstRow[inputArray.Length / 2 - i - 1] = inputArray[inputArray.Length - inputArray.Length/4 + i];

                secondRow[2*i] = inputArray[2*i + inputArray.Length/4];
                secondRow[2 * i + 1] = inputArray[inputArray.Length / 4 + 2 * i + 1];
            }

            int[] sum = new int[inputArray.Length / 2];
            for (int i = 0; i < sum.Length; i++)
            {
                
                sum[i] = firstRow[i] + secondRow[i];
            }

            
            return string.Join(" ", sum);
        }
    }
}
