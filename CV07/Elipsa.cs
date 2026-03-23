using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV07
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

        public override double Plocha()
        {
            return Math.PI * a * b;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}, hlavni = {a}, vedlejsi = {b}, plocha = {Plocha()}";
        }
    }
}
