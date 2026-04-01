
using System;

namespace CV08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArchivTeplot archiv = new ArchivTeplot();

            archiv.Load("../../../teploty.txt");

            Console.WriteLine("Všechny teploty:");
            archiv.TiskTeplot();

            Console.WriteLine();
            Console.WriteLine("Průměrné roční teploty:");
            archiv.TiskPrumerneTeploty();

            Console.WriteLine();
            Console.WriteLine("Průměrné měsíční teploty:");
            archiv.TiskPrumernychMesicnichTeplot();

            archiv.Kalibrace(-0.1);

            archiv.Save("../../../teploty_kalibrovane.txt");

            Console.WriteLine();
            Console.WriteLine("Kalibrovaná data byla uložena do souboru teploty_kalibrovane.txt");
        }
    }
}