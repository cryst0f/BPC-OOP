using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV07
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

        public override double Plocha()
        {
            return a * b;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}, strana a = {a}, strana b = {b}, plocha = {Plocha()}";
        }
    }
}
