using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    internal class Koule : Objekt3D
    {

        private double r;

        public Koule (double r)
        {
            this.r = r;
        }

        public override double SpoctiPovrch()
        {
            double result = 4 * Math.PI * r * r;
            return result;
        }

        public override double SpoctiObjem()
        {
            double result = (4 / 3) * Math.PI * r * r * r;
            return result;
        }

        public override void Kresli()
        {
            Console.WriteLine($"{this.GetType().Name}, polomer = {r}");
        }
    }
}
