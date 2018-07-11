using System;
using System.Linq;

namespace compare_char_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input1 = Console.ReadLine().Split().Select(Convert.ToChar).ToArray();
            char[] input2 = Console.ReadLine().Split().Select(Convert.ToChar).ToArray(); ;

            CompareCharacters(input1, input2);
        }

        private static void CompareCharacters(char[] input1, char[] input2)
        {
            if (input1.Length < input2.Length)
            {
                for (int i = 0; i < input1.Length; i++)
                {
                    if (input1[i] == input2[i])
                    {
                        if (i == input1.Length-1 && input1[i] == input2[i])
                        {
                            Console.WriteLine(string.Join("", input1));
                            Console.WriteLine(string.Join("", input2));
                            break;
                        }
                        continue;
                    }
                    else if (input1[i] < input2[i])
                    {
                        Console.WriteLine(string.Join("", input1));
                        Console.WriteLine(string.Join("", input2));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", input2));
                        Console.WriteLine(string.Join("", input1));
                        break;
                    }
                }
                
            }
            else if(input1.Length == input2.Length)
            {
                for (int i = 0; i < input1.Length; i++)
                {
                    if (input1[i] == input2[i])
                    {
                        if (i == input1.Length - 1 && input1[i] == input2[i])
                        {
                            Console.WriteLine(string.Join("", input1));
                            Console.WriteLine(string.Join("", input2));
                            break;
                        }
                        continue;
                    }
                    else if (input1[i] < input2[i])
                    {
                        Console.WriteLine(string.Join("", input1));
                        Console.WriteLine(string.Join("", input2));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", input2));
                        Console.WriteLine(string.Join("", input1));
                        break;
                    }
                }
                
            }
            else if(input1.Length > input2.Length)
            {
                for (int i = 0; i < input2.Length; i++)
                {
                    if (input1[i] == input2[i])
                    {
                        if (i == input2.Length - 1 && input1[i] == input2[i])
                        {
                            Console.WriteLine(string.Join("", input2));
                            Console.WriteLine(string.Join("", input1));
                            break;
                        }
                        continue;
                        
                    }
                    else if (input1[i] < input2[i])
                    {
                        Console.WriteLine(string.Join("", input1));
                        Console.WriteLine(string.Join("", input2));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", input2));
                        Console.WriteLine(string.Join("", input1));
                        break;
                    }
                }
                
            }
        }
    }
}

