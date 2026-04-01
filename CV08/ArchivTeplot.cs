using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CV08
{
    internal class ArchivTeplot
    {
        private SortedDictionary<int, RocniTeplota> _archiv;

        public ArchivTeplot()
        {
            _archiv = new SortedDictionary<int, RocniTeplota>();
        }

        public void Load(string cestaSoubor)
        {
            string[] obsahSouboru = File.ReadAllLines(cestaSoubor);

            foreach (string radek in obsahSouboru)
            {
                //zpracovani roku
                string[] data = radek.Split(':');
                int rok = int.Parse(data[0]);
                RocniTeplota r = new RocniTeplota(rok);

                //zpracovani teplot
                string[] teploty = data[1].Split(';');

                foreach (string teplota in teploty)
                {
                    string teplotaTrimmed = teplota.Trim();
                    double mesicniTeplota = double.Parse(teplotaTrimmed);
                    r.MesicniTeploty.Add(mesicniTeplota);
                }

                _archiv.Add(rok, r);
            }
        }

        public void Save(string cestaSoubor)
        {
            List<string> obsahSouboru = new List<string>();
            foreach (var rok in _archiv.Keys)
            {
                RocniTeplota r = _archiv[rok];
                string teploty = string.Join("; ", r.MesicniTeploty.Select(t => t.ToString("F1")));
                string radek = $"{rok}: {teploty}";
                obsahSouboru.Add(radek);
            }
            File.WriteAllLines(cestaSoubor, obsahSouboru);
        }

        public void Kalibrace(double kalibrace)
        {
            foreach (var rok in _archiv.Keys)
            {
                RocniTeplota r = _archiv[rok];
                for (int i = 0; i < r.MesicniTeploty.Count; i++)
                {
                    r.MesicniTeploty[i] += kalibrace;
                }
            }
        }

        public void TiskTeplot()
        {
            foreach (var rok in _archiv.Keys)
            {
                RocniTeplota r = _archiv[rok];
                Console.Write($"{rok}: ");
                for (int i = 0; i < r.MesicniTeploty.Count; i++)
                {
                    Console.Write($"{r.MesicniTeploty[i]}   ");
                }
                Console.WriteLine();
            }
        }

        public void TiskPrumerneTeploty()
        {
            foreach (var rok in _archiv.Keys)
            {
                RocniTeplota r = _archiv[rok];
                Console.WriteLine($"{rok}: {r.PrumRocniTeplota:F1}");
            }
        }

        public void TiskPrumernychMesicnichTeplot()
        {
            Console.Write("Prum.: ");
            for (int mesic = 0; mesic < 12; mesic++)
            {
                double prumerMesicniTeplota = _archiv.Values.Average(r => r.MesicniTeploty[mesic]);
                Console.Write($"{prumerMesicniTeplota:F1}   ");
            }
        }
    }
}
