using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV07
{
    internal class Kruh : Objekt2D
    {
        private double r;
        public Kruh(double r)
        {
            this.r = r;
        }
        public override double Plocha()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}, polomer = {r}, plocha = {Plocha()}";
        }

    }
}
