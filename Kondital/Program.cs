using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kondital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast din puls: ");
            int puls = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIndtast din max puls: ");
            int maxpuls = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIndtast din vægt: ");
            double vægt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Main(puls, maxpuls, vægt));

        }
        static string Main(int puls, int maxpuls, double vægt)
        {
            double kondital = maxpuls / puls * 15.3, maxilt = kondital * vægt / 1000;
            return "Kondital: "+Math.Round(kondital).ToString()+"\nMax iltoptagelse: "+Math.Round(maxilt).ToString()+" liter";
        }
    }
}
