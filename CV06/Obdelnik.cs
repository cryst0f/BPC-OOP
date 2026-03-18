using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    internal class Obdelnik : Objekt2D
    {
        private double a;
        private double b;

        public Obdelnik(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double SpoctiPlochu()
        {
            double result = 2 * a * b;
            return result;
        }

        public override void Kresli()
        {
            Console.WriteLine($"{this.GetType().Name}, strana a = {a}, strana b = {b}");
        }

    }
}
