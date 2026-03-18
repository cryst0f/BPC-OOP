using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    internal class Kvadr : Objekt3D
    {
        double a;
        double b;
        double c;

        public Kvadr(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double SpoctiPovrch()
        {
            double result = 2 * ((a * c) + (a * c) + (b * c));

            return result;
        }
        public override double SpoctiObjem()
        {
            double result = a * b * c;
            return result;
        }

        public override void Kresli()
        {
            Console.WriteLine($"{this.GetType().Name}, a = {a}, b = {b}, c = {c}");
        }
    }
}
