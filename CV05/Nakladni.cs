using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV05
{
    public class Nakladni : Auto
    {
        public double MaxNaklad { get; private set; }

        private double prepravovanyNaklad;

        public double PrepravovanyNaklad
        {
            get { return prepravovanyNaklad; }
            set
            {
                prepravovanyNaklad = CheckNaklad(value);
            }
        }

        public Nakladni(double velikostNadrze, double stavNazdrze, TypPaliva palivo, double maxNaklad = 0, double prepravovanyNaklad = 0)
            : base(velikostNadrze, stavNazdrze, palivo)
        {
            MaxNaklad = maxNaklad;
            PrepravovanyNaklad = prepravovanyNaklad;
        }

        public double CheckNaklad(double prepravovanyNaklad)
        {
            if (prepravovanyNaklad > MaxNaklad)
            {
                throw new Exception("Prepravovany naklad je vetsi nez maximalni naklad");
            }
            return prepravovanyNaklad;
        }

        public override string ToString()
        {
            return String.Format("{0} Nalozeny naklad {1}.", base.ToString(), prepravovanyNaklad);
        }
    }
}
