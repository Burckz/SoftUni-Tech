using System;

namespace Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 1;
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= n; i++)
            //{
            //    Console.WriteLine(num);
            //    num = num * 2;
            //}

            int n = int.Parse(Console.ReadLine());

            int power = (int)Math.Pow(2, n);
            for (int i = 1; i <= power; i=i*2)
            {
                Console.WriteLine(i);
            }

        }
    }
}
