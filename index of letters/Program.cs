using System;
using System.Collections.Generic;

namespace index_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            ReturnResult(input);
        }

        private static void ReturnResult(string input)
        {


            char[] alphabet = new char[26];
            char[] inputChars = input.ToCharArray(0, input.ToCharArray().Length);
            int count = 0;

            for (char c = 'a'; c <= 'z'; c++)
            {
                for (int number = count; number < alphabet.Length; number++)
                {
                    alphabet[number] = c;
                    break;
                }
                count++;
            }
            

            for (int i = 0; i < inputChars.Length; i++)
            {
                for (int y = 0; y < alphabet.Length; y++)
                {
                    if ( inputChars[i] == alphabet[y])
                    {
                        Console.WriteLine($"{inputChars[i]} -> {y}");
                    }
                }
            }
        }
        
    }
    
}
