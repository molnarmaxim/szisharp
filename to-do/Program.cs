using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            Console.WriteLine("To-Do App");

            bool folytat = true;

            while (folytat)
            {
                Console.WriteLine("Add meg a dolgokat amiket meg kell csinálnod: (Ha már nem akarsz megadni semmit nyomj egy entert!)");
                Console.Write("Hozzáadás: ");
                string dolog = Console.ReadLine();
                if (dolog.Length > 0)
                {
                    lista.Add(dolog);
                }
                else
                {
                    folytat = false;
                    
                }
                
            }
            Console.WriteLine(string.Join("\n", lista));


        }
    }
}
