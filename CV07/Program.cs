using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CV07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 1, 3, 5, 7, 9 };
            string[] slova = { "Ahoj", "cau", "vitejte", "nashledanou" };
            Kruh[] kruh = { new Kruh(11), new Kruh(5), new Kruh(3), new Kruh(4) };
            Obdelnik[] obdelnik = { new Obdelnik(1, 5), new Obdelnik(3, 4), new Obdelnik(5, 2), new Obdelnik(9, 2) };
            Elipsa[] elipsa = { new Elipsa(3, 4), new Elipsa(1, 2), new Elipsa(11, 6), new Elipsa(7, 8) };
            Trojuhelnik[] trojuhelnik = { new Trojuhelnik(3, 5, 7), new Trojuhelnik(4, 5, 6), new Trojuhelnik(7, 8, 9), new Trojuhelnik(10, 11, 12) };
            Ctverec[] ctverec = { new Ctverec(1), new Ctverec(2), new Ctverec(3), new Ctverec(4) };
            Objekt2D[] objekty = { new Ctverec(2), new Elipsa(7, 8), new Obdelnik(5, 6), new Kruh(2), new Trojuhelnik(4, 5, 6) };


            //cisla
            Console.WriteLine("Cisla");
            Console.WriteLine(string.Join(", ", cisla));
            Console.WriteLine($"\nNejvetsi: {Extremy.Nejvetsi(cisla)}");
            Console.WriteLine($"Nejmensi: {Extremy.Nejmensi(cisla)}");

            //stringy
            Console.WriteLine("\nSlova");
            Console.WriteLine(string.Join(", ", slova));
            Console.WriteLine($"\nNejvetsi: {Extremy.Nejvetsi(slova)}");
            Console.WriteLine($"Nejmensi: {Extremy.Nejmensi(slova)}");

            //kruh
            Console.WriteLine("\nKruh");
            foreach (var item in kruh)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\nNejvetsi: {Extremy.Nejvetsi(kruh)}");
            Console.WriteLine($"Nejmensi: {Extremy.Nejmensi(kruh)}");

            //obdelnik
            Console.WriteLine("\nObdelnik");
            foreach (var item in obdelnik)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\nNejvetsi: {Extremy.Nejvetsi(obdelnik)}");
            Console.WriteLine($"Nejmensi: {Extremy.Nejmensi(obdelnik)}");

            //elipsa
            Console.WriteLine("\nElipsa");
            foreach (var item in elipsa)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\nNejvetsi: {Extremy.Nejvetsi(elipsa)}");
            Console.WriteLine($"Nejmensi: {Extremy.Nejmensi(elipsa)}");

            //trojuhelnik
            Console.WriteLine("\nTrojuhelnik");
            foreach (var item in trojuhelnik)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\nNejvetsi: {Extremy.Nejvetsi(trojuhelnik)}");
            Console.WriteLine($"Nejmensi: {Extremy.Nejmensi(trojuhelnik)}");

            //ctverec
            Console.WriteLine("\nCtverec");
            foreach (var item in ctverec)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\nNejvetsi: {Extremy.Nejvetsi(ctverec)}");
            Console.WriteLine($"Nejmensi: {Extremy.Nejmensi(ctverec)}");

            //Objekty
            Console.WriteLine("\nObjekty");
            foreach (var item in objekty)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\nNejvetsi: {Extremy.Nejvetsi(objekty)}");
            Console.WriteLine($"Nejmensi: {Extremy.Nejmensi(objekty)}");

            //linq filtr
            Console.WriteLine("\nLinq filtr");
            int[] filtrovana = cisla.Where(x => x >= 4 && x <= 8).ToArray();
            Console.WriteLine(string.Join(", ", filtrovana));
        }
    }
}