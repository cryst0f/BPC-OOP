using System;

namespace CV05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osobni osobni = new Osobni(50, 20, Auto.TypPaliva.Benzin, 5, 3);

            osobni.setZapnuto(true);
            osobni.setKmitocet(101.5);

            osobni.setNewPreset(1, 90.5);
            osobni.setNewPreset(2, 105.2);

            osobni.setPreset(1);
            osobni.Natankuj(Auto.TypPaliva.Benzin, 3);
            Console.WriteLine("Osobni auto:");
            Console.WriteLine("Radio zapnuto: " + osobni.getZapnuto());
            Console.WriteLine("Naladeny kmitocet: " + osobni.getRadioKmitocet());
            Console.WriteLine(osobni);


            Nakladni nakladni = new Nakladni(120, 60, Auto.TypPaliva.Nafta, 10000, 5000);
            
            nakladni.setZapnuto(true);
            nakladni.setKmitocet(99.8);

            nakladni.setNewPreset(1, 88.3);
            nakladni.setPreset(1);
            
            Console.WriteLine("\nNakladni auto:");
            Console.WriteLine("Radio zapnuto: " + nakladni.getZapnuto());
            Console.WriteLine("Naladeny kmitocet: " + nakladni.getRadioKmitocet());
            Console.WriteLine(nakladni);

            Console.ReadLine();
        }
    }
}