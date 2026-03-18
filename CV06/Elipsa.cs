using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    internal class Elipsa : Objekt2D
    {
        private double a;
        private double b;

        public Elipsa(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double SpoctiPlochu()
        {
            double result = Math.PI * a * b;

            return result;
        }

        public override void Kresli()
        {
            Console.WriteLine($"{this.GetType().Name}, hlavni = {a}, vedlejsi = {b}");
        }
    }
}
