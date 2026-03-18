using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    internal class Jehlan : Objekt3D
    {

        private double a;
        private double b;
        private double v;
        private double stena;

        public Jehlan(double a, double b, double v, double stena)
        {
            this.a = a;
            this.b = b;
            this.v = v;
            this.stena = stena;
        }

        public override double SpoctiPovrch()
        {
            double obsahPodstava = a * b;
            double obsahPlaste = stena * 0.5 * a * b;
            double result = obsahPlaste + obsahPodstava;
            return result;
        }
        public override double SpoctiObjem()
        {
            double obsahPlaste = stena * 0.5 * a * b;
            double result = (1.0 / 3.0) * obsahPlaste * v;
            return result;
        }

        public override void Kresli()
        {
            Console.WriteLine($"{this.GetType().Name}, strana a = {a}, strana b = {b}, vyska v = {v}, pocet sten = {stena}");
        }
    }
}