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
            int vægt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Main(puls, maxpuls, vægt));

        }
        static int Main(int puls, int maxpuls, int vægt)
        {
            int kondital = maxpuls / puls * (int)15.3;
            return kondital * vægt / 1000;
        }
    }
}

class KonditalNr2
{

}