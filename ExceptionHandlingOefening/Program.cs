using System;
using System.Collections.Generic;

namespace ExceptionHandlingOefening
{
    class Program
    {
        /// <summary>
        /// Check de leeftijd van een lijst van katten, returned true indien de leeftijd boven 0 is, zoniet word een customCatError gethrowed
        /// </summary>
        /// <param name="cats"></param>
        /// <returns></returns>
        private static bool CheckCatLeeftijd(List<Cat> cats)
        {
            foreach (Cat cat in cats)
            {
                if (cat.Age <= 0)
                {
                    throw new CustomCatError("A cat in the list has an invalid age.(Age <= 0)");
                }

            }
            return true;
        }

        static void Main(string[] args)
        {
            /*  
             Oefening 1 
             */
            bool tryAgain = true;
            while (tryAgain) {
                try
                {
                    int[] ar = { 10, 20, 30 };
                    Console.Write("Geef een getal tussen 1 en 3 op om de waarde van dat element binnen de array te verkrijgen:");
                    var getal = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(ar[getal - 1]);
                    tryAgain = false;
                }
                catch (IndexOutOfRangeException ioore)
                {
                    Console.WriteLine("Geen getal tussen 1 en 3");
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Geen geldig getal");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            /*  
             Oefening 2
             */
            List<Cat> cats = new List<Cat>();
            cats.Add(new Cat(2));
            cats.Add(new Cat(5));
            cats.Add(new Cat(6));
            cats.Add(new Cat(3));

            ///Deze lijn voegt een cat toe met leeftijd 0
            ///cats.Add(new Cat(0));
            ///
            ///Deze lijn voegt een cat toe met leeftijd -1
            cats.Add(new Cat(-1));
            
            try
            {
                Console.WriteLine(CheckCatLeeftijd(cats));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
}
