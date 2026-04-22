using System;

namespace CV11.EFcore
{
    public static class Data
    {
        public static void Seed(VyukaContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Predmety.Any())
            {
                context.Predmety.AddRange(
                    new Predmet { PredmetId = 1, Zkratka = "BPC-IC2", Nazev = "Bezpecnost ICT 2" },
                    new Predmet { PredmetId = 2, Zkratka = "BPC-MDS", Nazev = "Multimedialni sluzby" },
                    new Predmet { PredmetId = 3, Zkratka = "BPC-SPR", Nazev = "Softwarove pravo" },
                    new Predmet { PredmetId = 4, Zkratka = "BPC-OOP", Nazev = "Objektove orientovane programovani" }
                );

                context.SaveChanges();
            }

            if (!context.Studenti.Any())
            {
                context.Studenti.AddRange(
                    new Student { StudentId = 1, Jmeno = "Jan", Prijmeni = "Novak", DatumNarozeni = new DateTime(2000, 1, 1) },
                    new Student { StudentId = 2, Jmeno = "Petr", Prijmeni = "Novak", DatumNarozeni = new DateTime(1999, 5, 15) },
                    new Student { StudentId = 3, Jmeno = "Eva", Prijmeni = "Kralova", DatumNarozeni = new DateTime(2001, 9, 30) },
                    new Student { StudentId = 4, Jmeno = "Tomas", Prijmeni = "Dlouhy", DatumNarozeni = new DateTime(2000, 12, 12) }
                );

                context.SaveChanges();
            }

            if (!context.ZapsanyPredmet.Any())
            {
                context.ZapsanyPredmet.AddRange(
                    new ZapsanyPredmet { StudentId = 1, PredmetId = 1 },
                    new ZapsanyPredmet { StudentId = 1, PredmetId = 2 },
                    new ZapsanyPredmet { StudentId = 2, PredmetId = 3 },
                    new ZapsanyPredmet { StudentId = 2, PredmetId = 4 },
                    new ZapsanyPredmet { StudentId = 3, PredmetId = 4 },
                    new ZapsanyPredmet { StudentId = 3, PredmetId = 2 },
                    new ZapsanyPredmet { StudentId = 4, PredmetId = 1 },
                    new ZapsanyPredmet { StudentId = 4, PredmetId = 4 }
                );

                context.SaveChanges();
            }

            if (!context.Hodnoceni.Any())
            {
                context.Hodnoceni.AddRange(
                    new Hodnoceni { StudentId = 1, PredmetId = 1, DatumHodnoceni = new DateTime(2026, 1, 15), HodnoceniStudenta = 1 },
                    new Hodnoceni { StudentId = 1, PredmetId = 2, DatumHodnoceni = new DateTime(2026, 2, 20), HodnoceniStudenta = 2 },
                    new Hodnoceni { StudentId = 2, PredmetId = 3, DatumHodnoceni = new DateTime(2026, 1, 30), HodnoceniStudenta = 3 },
                    new Hodnoceni { StudentId = 2, PredmetId = 4, DatumHodnoceni = new DateTime(2026, 3, 10), HodnoceniStudenta = 4 },
                    new Hodnoceni { StudentId = 3, PredmetId = 4, DatumHodnoceni = new DateTime(2026, 2, 25), HodnoceniStudenta = 1 },
                    new Hodnoceni { StudentId = 3, PredmetId = 2, DatumHodnoceni = new DateTime(2026, 3, 5), HodnoceniStudenta = 2 },
                    new Hodnoceni { StudentId = 4, PredmetId = 1, DatumHodnoceni = new DateTime(2026, 1, 20), HodnoceniStudenta = 3 },
                    new Hodnoceni { StudentId = 4, PredmetId = 4, DatumHodnoceni = new DateTime(2026, 2, 28), HodnoceniStudenta = 4 }
                );

                context.SaveChanges();
            }
        }
    }
}