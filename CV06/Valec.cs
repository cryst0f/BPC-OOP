using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    internal class Valec : Objekt3D
    {
        private double r;
        private double v;

        public Valec(double r, double v)
        {
            this.r = r;
            this.v = v;
        }

        public override double SpoctiPovrch()
        {
            double result = 2 * Math.PI * r * (r + v);
            return result;
        }
        public override double SpoctiObjem()
        {
            double result = Math.PI * r * v;
            return result;
        }

        public override void Kresli()
        {
            Console.WriteLine($"{this.GetType().Name}, polomer = {r}, vyska = {v}");
        }
    }
}
