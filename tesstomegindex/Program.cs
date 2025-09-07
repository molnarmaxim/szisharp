using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesstomegindex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * J 3.4. feladat I [Testtömeg indexek] Írjunk programot, mely a testsúly és a testmagasság alapján meghatározza a testtömegindexet, és kiírja, hogy milyen testsúly osztályba tartozik az adott illető. a testtömeg osztályokat meghatározhatjuk tetszőlegesen,
de alapul vehetünk létező osztályozásokat is.
Testtomegindex = T esttomeg[kg]/testmagassg2
[m
2

             */

            Console.Write("Kérlek add meg a testsúlyod: ");
            double testSuly = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kérlek add meg a magasságodat: ");
            double magassag = Convert.ToDouble(Console.ReadLine());

            double magassagM = magassag / 100.0;

            double testtomegindex = testSuly / (magassagM * magassagM);

            Console.WriteLine("A testtömegindexed: " + Math.Round(testtomegindex, 2));

            if (testtomegindex < 18.5)
            {
                Console.WriteLine("Sovány vagy.");
            }
            else if (18.5 < testtomegindex && testtomegindex < 24.9)
            {
                Console.WriteLine("Normál testsúllyal rendelkezel.");
            }
            else if (24.9 < testtomegindex && testtomegindex < 29.00)
            {
                Console.WriteLine("Túlsúlyos vagy");
            }
            else if (testtomegindex > 29.00)
            {
                Console.WriteLine("Dagadt vagy");
            }
        }
    }
}
