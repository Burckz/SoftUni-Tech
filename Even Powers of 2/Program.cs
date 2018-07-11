using System;

namespace Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for(int number=0; number <= n; number++)
            {
                if(number%2==0)
                {
                    Console.WriteLine(num);
                }
                num = num * 2;
            }
        }
    }
}
