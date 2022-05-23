using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonditalV2
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
            Console.WriteLine(Kondital.CalcKondital(puls, maxpuls, vægt));
        }
    }
    class Kondital
    {
        public static string CalcKondital(int puls, int maxpuls, double vægt)
        {
            double kondital = maxpuls / puls * 15.3, maxilt = kondital * vægt / 1000;
            return "Kondital: " + (int)kondital + "\nMax iltoptagelse: " + (int)maxilt + " liter";
        }
    }
}
