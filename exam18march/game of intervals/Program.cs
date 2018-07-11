using System;

namespace game_of_intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hodove = int.Parse(Console.ReadLine());
            double obshtRezultat = 0;
            double chestotaEdno = 0;
            double chestotaDve = 0;
            double chestotaTri = 0;
            double chestotaChetiri = 0;
            double chestotaPet = 0;
            double ChestotaShest = 0;
            
            for (int i = 0; i < hodove; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number >=0 && number < 10)
                {
                    obshtRezultat = obshtRezultat + (number * 0.2);
                    chestotaEdno = chestotaEdno + 1;
                }
                else if(number >= 10 && number < 20)
                {
                    obshtRezultat = obshtRezultat + (number * 0.3);
                    chestotaDve = chestotaDve + 1;
                }
                else if(number >= 20 && number < 30)
                {
                    obshtRezultat = obshtRezultat + (number * 0.4);
                    chestotaTri = chestotaTri + 1;
                }
                else if(number >= 30 && number < 40)
                {
                    obshtRezultat = obshtRezultat + 50;
                    chestotaChetiri = chestotaChetiri + 1;
                }
                else if(number >= 40 && number <= 50)
                {
                    obshtRezultat = obshtRezultat + 100;
                    chestotaPet = chestotaPet + 1;
                }
                else if(number < 0 || number > 50)
                {
                    obshtRezultat = obshtRezultat / 2;
                    ChestotaShest = ChestotaShest + 1;
                }
            }

            double procentEdno = chestotaEdno  * 100 / hodove;
            double procentDve = chestotaDve * 100 / hodove;
            double procentTri = chestotaTri * 100 / hodove;
            double procentChetiri = chestotaChetiri * 100 / hodove;
            double procentPet = chestotaPet * 100 / hodove;
            double procentShest = ChestotaShest * 100 / hodove;

            Console.WriteLine(obshtRezultat.ToString("f2"));
            Console.WriteLine($"From 0 to 9: {procentEdno.ToString("f2")}%");
            Console.WriteLine($"From 10 to 19: {procentDve.ToString("f2")}%");
            Console.WriteLine($"From 20 to 29: {procentTri.ToString("f2")}%");
            Console.WriteLine($"From 30 to 39: {procentChetiri.ToString("f2")}%");
            Console.WriteLine($"From 40 to 50: {procentPet.ToString("f2")}%");
            Console.WriteLine($"Invalid numbers: {procentShest.ToString("f2")}%");
           
        }
    }
}
