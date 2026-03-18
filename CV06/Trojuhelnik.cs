using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    internal class Trojuhelnik : Objekt2D
    {
        private double a;
        private double b;
        private double c;

        public Trojuhelnik(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double SpoctiPlochu()
        {
            double s = (a + b + c) / 2;
            double result = Math.Sqrt(s * (s - a) * s * (s - b) * s*(s - c));
            return result;
        }

        public override void Kresli()
        {
            Console.WriteLine($"{this.GetType().Name}, strana a = {a}, strana b = {b}, strana c = {c}");
        }
    }
}
