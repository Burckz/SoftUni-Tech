using System;

namespace rent_a_car
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string klas = null;
            string carType = null;
            var costs = 0.00;


            if (budget <= 100)
            {
                klas = "Economy class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    costs = budget * 0.35;
                }
                else if(season == "Winter")
                {
                    carType = "Jeep";
                    costs = budget * 0.65;
                }

            }
            else if(budget > 100 && budget <= 500)
            {
                klas = "Compact class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    costs = budget * 0.45;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    costs = budget * 0.80;
                }
            }
            else if(budget > 500)
            {
                klas = "Luxury class";
                carType = "Jeep";
                costs = budget * 0.9;
            }

            Console.WriteLine(klas);
            Console.WriteLine($"{carType} - {costs.ToString("f2")}");
        }
    }
}
