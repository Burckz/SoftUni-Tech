using System;

namespace exam18march
{
    class Program
    {
        static void Main(string[] args)
        {
            double stranaA = double.Parse(Console.ReadLine());
            double visochina = double.Parse(Console.ReadLine());
            var stranaB = stranaA / 2;
            var licePravoulgulnik = stranaA * stranaB;
            var liceKvardrat = stranaB * stranaB;
            var liceTriugulnik = (stranaB * (visochina-stranaB)) / 2;
            var ploshtVhod = (stranaA / 5) * (stranaA / 5);
            var licePredenKvadrat = liceKvardrat - ploshtVhod;
            var licePokriv = licePravoulgulnik;

            var chervenaBoq = (licePokriv * 2) / 5;
            var zelenaBoq = ((2 * licePravoulgulnik) + (2 * liceTriugulnik) + liceKvardrat + licePredenKvadrat) / 3;

            Console.WriteLine(zelenaBoq.ToString("f2"));
            Console.WriteLine(chervenaBoq.ToString("f2"));
            

        }
    }
}
