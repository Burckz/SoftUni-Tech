using System;

namespace work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int neobhodimiChasove = int.Parse(Console.ReadLine());
            int broiRabotnici = int.Parse(Console.ReadLine());
            int rabotniDni = int.Parse(Console.ReadLine());

            var proizvoditelnost = broiRabotnici * (rabotniDni * 8);
            var razlika = neobhodimiChasove - proizvoditelnost;

            if(razlika < 0)
            {
                razlika = Math.Abs(razlika);
                Console.WriteLine($"{razlika} hours left");
            }
            else
            {
                var neustoiki = razlika * rabotniDni;
                Console.WriteLine($"{razlika} overtime");
                Console.WriteLine($"Penalties: {neustoiki}");
            }
        }
    }
}
