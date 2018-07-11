using System;

namespace Arrays___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = Console.ReadLine();
            string two = Console.ReadLine();

            LargestCommonEnd(one, two);
        }

        private static void LargestCommonEnd(string one, string two)
        {
            int count = 0;
            string[] arrayOne = one.Split();
            string[] arrayTwo = two.Split();
            int x = arrayOne.Length - 1;
            int y = arrayTwo.Length - 1;

            if (arrayOne.Length > arrayTwo.Length)
            {
                for (int i = 0; i < arrayTwo.Length; i++)
                {
                    if ( arrayOne[i] == arrayTwo[i])
                    {
                        count++;
                    }
                }

                while (y >= 0)
                {
                    if (arrayOne[x] == arrayTwo[y])
                    {
                        count++;
                    }
                    x--;
                    y--;
                }
            }
            else if(arrayOne.Length == arrayTwo.Length)
            {
                for (int i = 0; i < arrayTwo.Length; i++)
                {
                    if (arrayOne[i] == arrayTwo[i])
                    {
                        count++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < arrayOne.Length; i++)
                {
                    if (arrayOne[i] == arrayTwo[i])
                    {
                        count++;
                    }
                }

                for (int i = arrayOne.Length - 1; i >= 0; i--)
                {
                    if (arrayTwo[i] == arrayOne[i])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
