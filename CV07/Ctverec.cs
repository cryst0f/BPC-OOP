using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV07
{
    internal class Ctverec : Objekt2D
    {
        private double a;
        public Ctverec(double a)
        {
            this.a = a;
        }

        public override double Plocha()
        {
            return Math.Pow(a, 2);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}, delka strany = {a}, plocha = {Plocha()}";
        }
    }
}
