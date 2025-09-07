using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizallapot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Víz halmazállapota
             * 
             */
            Console.Write("Kérlek add meg a víz hőmérsékletet:");

            double t = Convert.ToDouble(Console.ReadLine());

            if (t < 0)
            {
                Console.WriteLine("Jég");
            }
            else if (0 < t && t < 100)
            {
                Console.WriteLine("Víz");
            }
            else if (t > 100)
            {
                Console.WriteLine("Gőz");
            }

        }
    }
}
