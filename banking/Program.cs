using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int banki_egyenleg = 5000;
            int keszpenz = 0;

            Console.WriteLine("Üdvözöllek a Bankban kedves Felhasználó!\n4 opció közül választhatsz:\n- 1. Pénzfelvétel\n- 2. Pénzfeltöltés\n- 3. Euro-Ft átváltás\n- 4. Kilépés");

            bool folytat = true;

            while (folytat) { 
            Console.WriteLine($"\nKészpénzed: {keszpenz}\nBanki egyenleged: {banki_egyenleg}");

            Console.Write("\nKérlek válassz egy opciót! : ");

            int valasztottOpcio = Convert.ToInt32(Console.ReadLine());

            switch (valasztottOpcio)
            {
                default:
                        Console.WriteLine("Hibás opció");
                        continue;
                case 1:
                        Console.WriteLine("Pénzfelvételi mód kiválasztva");
                        Console.Write("Mennyi pénzt szeretnél kivenni az ATM-ből? ");

                        int osszeg = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Pénzlevétel folyamatban...");
                        System.Threading.Thread.Sleep(1000);
                        banki_egyenleg = banki_egyenleg - osszeg;
                        keszpenz = keszpenz + osszeg;
                        continue;
                case 2:
                        Console.WriteLine("Pénzfeltöltési mód kiválasztva");
                        Console.Write("Mennyi pénzt szeretnél betenni a bankba? ");

                        osszeg = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Pénzfeltöltése folyamatban...");
                        System.Threading.Thread.Sleep(1000);

                        banki_egyenleg = banki_egyenleg + osszeg;
                        keszpenz = keszpenz - osszeg;
                        continue;
                case 3:
                        double euroforintArfolyam = 392.83;
                        Console.Write("Euró átváltási árfolyama: 1 EUR = 392.83 HUF\nMennyi forintot szeretnél átváltani?");
                        double hufOsszeg = Convert.ToDouble(Console.ReadLine());

                        double eurOsszeg = hufOsszeg / euroforintArfolyam;
                        Console.WriteLine($"{Math.Round(eurOsszeg, 2)} eurónak felel meg a {hufOsszeg} Ft-od.");

                        continue;
                case 4:
                        folytat = false;
                        break;

            }

            }
        }
    }
}
