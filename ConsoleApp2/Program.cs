using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Oszthatóság kettővel
             * 
             */

            Console.Write("Kérlek adj meg egy számot: ");
            int megadottSzam = Convert.ToInt32(Console.ReadLine());

            if (megadottSzam % 2 == 0 )
            {
                Console.WriteLine("A megadott szám osztható kettővel.");
            }
            else
            {
                Console.WriteLine("A megadott szám nem osztható kettővel.");
            }
        }
    }
}
