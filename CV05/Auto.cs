using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CV05
{
    public abstract class Auto
    {

        AutoRadio radio {  get; set; }
        public Auto(double velikostNadrze, double stavNadrze, TypPaliva palivo)
        {
            VelikostNadrze = velikostNadrze;
            StavNadrze = stavNadrze;
            Palivo = palivo;
            radio = new AutoRadio();
        }
        public enum TypPaliva
        {
            Benzin,
            Nafta
        }

        public double VelikostNadrze { get; private set; }
        public double StavNadrze { get; private set; }
        public TypPaliva Palivo { get; private set; } 



        public void Natankuj(TypPaliva typPaliva, double mnozstvi)
        {
            if (StavNadrze + mnozstvi < VelikostNadrze && typPaliva == Palivo)
            {
                StavNadrze += mnozstvi;
            }
            else
            {
                throw new Exception("Limit nadrze prekorcen nebo spatne palivo");
            }
        }

        public double getRadioKmitocet()
        {
            return radio.NaladenyKmitocet;
        }

        public bool getZapnuto()
        {
            return radio.Zapnuto;
        }

        public void setZapnuto(bool zapnuto)
        {
            radio.Zapnuto = zapnuto;
        }

        public void setNewPreset(int index, double kmitocet)
        {
            radio.NastavPredvolbu(index, kmitocet);
        }

        public void setPreset(int index)
        {
            radio.PreladNaPredvolbu(index);
        }

        public void setKmitocet(double kmitocet)
        {
            radio.NaladenyKmitocet = kmitocet;
        }


        public override string ToString()
        {
            return String.Format("Stav nadrze {0} z {1}. Palivo {2}. {3}. ", StavNadrze, VelikostNadrze, Palivo, radio.ToString());
        }

    }
}
