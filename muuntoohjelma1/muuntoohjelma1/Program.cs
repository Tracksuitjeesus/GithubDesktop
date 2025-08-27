using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muuntoohjelma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaikki yksiköt: mm, cm, m, km, tuuma, jalka, maili");

            Console.Write("Syötä yksikkö mistä olet kääntämässä: ");
            string lukumistäkäännetään = Console.ReadLine().ToLower();

            Console.Write("Syötä yksikkö mihin käännät: ");
            string yksikkömihikäännetään = Console.ReadLine().ToLower();

            Console.Write("Syötä luku: ");
            double arvo = double.Parse(Console.ReadLine());

            
            double arvoMetreinä = 0.0;
            if (lukumistäkäännetään == "mm") arvoMetreinä = arvo * 0.001;
            else if (lukumistäkäännetään == "cm") arvoMetreinä = arvo * 0.01;
            else if (lukumistäkäännetään == "m") arvoMetreinä = arvo;
            else if (lukumistäkäännetään == "km") arvoMetreinä = arvo * 1000.0;
            else if (lukumistäkäännetään == "tuuma") arvoMetreinä = arvo * 0.0254;
            else if (lukumistäkäännetään == "jalka") arvoMetreinä = arvo * 0.3048;
            else if (lukumistäkäännetään == "maili") arvoMetreinä = arvo * 1609.344;
            else
            {
                Console.WriteLine("Väärä lähtöyksikkö!");
                return;
            }

 
            double muutettuArvo = 0.0;
            if (yksikkömihikäännetään == "mm") muutettuArvo = arvoMetreinä / 0.001;
            else if (yksikkömihikäännetään == "cm") muutettuArvo = arvoMetreinä / 0.01;
            else if (yksikkömihikäännetään == "m") muutettuArvo = arvoMetreinä;
            else if (yksikkömihikäännetään == "km") muutettuArvo = arvoMetreinä / 1000.0;
            else if (yksikkömihikäännetään == "tuuma") muutettuArvo = arvoMetreinä / 0.0254;
            else if (yksikkömihikäännetään == "jalka") muutettuArvo = arvoMetreinä / 0.3048;
            else if (yksikkömihikäännetään == "maili") muutettuArvo = arvoMetreinä / 1609.344;
            else
            {
                Console.WriteLine("Väärät kirjaimet osaaks lukea!");
                double kmysys = double.Parse(Console.ReadLine());
                return;
            }

            Console.WriteLine(arvo + " " + lukumistäkäännetään + " = " + muutettuArvo + " " + yksikkömihikäännetään);
            // urho niinimäki teki tämän
        }
    }
}
