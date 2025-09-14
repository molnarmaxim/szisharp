using System;

namespace numberguessr
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rnd =  new Random();
            int szam = rnd.Next(0, 101);

            Console.WriteLine("Gondoltam egy számra! Találd ki!");
            
            
            bool kitalalt = false;

            while (kitalalt == false)
            {
                Console.Write("Tipp: ");
                int tipp = Convert.ToInt32(Console.ReadLine());
                if (szam == tipp)
                {
                    kitalalt = true;
                    Console.WriteLine("Gratulálok eltaláltad a számot!!");
                }
                else if (szam < tipp)
                {
                    kitalalt = false; 
                    Console.WriteLine("Ajjaj, túl nagyra tippelsz! A kitalálandó szám kisebb, mint " + tipp);
                    
                }
                else if (szam > tipp)
                {
                    kitalalt = false;
                    Console.WriteLine("Ajjaj, a szám nagyobb, mint " + tipp);
                }
            }
        }
    }
}