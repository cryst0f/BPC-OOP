using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV05
{
    internal class AutoRadio
    {
        public bool Zapnuto { get; set; }
        public double NaladenyKmitocet { get; set; }
        private Dictionary<int, double> predvolba = new Dictionary<int, double>();

        public AutoRadio(double naladenyKmitocet = 90.0)
        {
            NaladenyKmitocet = naladenyKmitocet;
            Zapnuto = false;
        }

        public void NastavPredvolbu(int id, double kmitocet)
        {
            if (!predvolba.ContainsKey(id))
            {
                predvolba.Add(id, kmitocet);
            }
            else
            {
                predvolba.Remove(id);
                predvolba.Add(id, kmitocet);
            }
        }

        public void PreladNaPredvolbu(int id)
        {
            if (predvolba.TryGetValue(id, out double kmitocet))
            {
                this.NaladenyKmitocet = kmitocet;
            }
            else
            {
                throw new Exception("Tato predolba neni v seznamu");
            }
        }

        public override string ToString()
        {
            if (Zapnuto == false)
            {
                return "Radio je vypnuto";
            }
            else
            {
                return String.Format("Frekvence: {0, 0:N2}", NaladenyKmitocet);
            }

        }
    }
    }
