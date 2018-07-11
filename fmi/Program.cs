using System;

namespace fmi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('/');
            string[] paint = { "C", "D", "H", "S" };
            
            
            
            for (int i=0; i < 4; i++)
            {
                if( input[1] == paint[i])
                {
                    if (i == 3)
                    {
                        Console.WriteLine($"Previous: {input[0]}/{paint[i - 1]}");
                        Console.WriteLine($"Next: {input[0]}/{paint[0]}");
                    }
                    else
                    {
                        Console.WriteLine($"Previous: {input[0]}/{paint[i - 1]}");
                        Console.WriteLine($"Next: {input[0]}/{paint[i + 1]}");
                    }
                   
                }
            }
            
        }
    }
}
