using CV11.EFcore;
//4
using var context = new VyukaContext();
context.Database.EnsureDeleted();
context.Database.EnsureCreated();
Data.Seed(context);

// 5
Console.WriteLine("Predmety a pocet zapsanych studentu");

var predmetyStudenti = context.Predmety
    .Select(p => new
    {
        p.PredmetId,
        p.Zkratka,
        p.Nazev,
        PocetStudentu = context.ZapsanyPredmet.Count(z => z.PredmetId == p.PredmetId)
    })
    .OrderByDescending(p => p.PocetStudentu)
    .ToList();

foreach (var predmet in predmetyStudenti)
{
    Console.WriteLine($"{predmet.Zkratka} - {predmet.Nazev}: {predmet.PocetStudentu}");
}

Console.WriteLine();

// 6
IEnumerable<Student> StudentiPredmetu(int predmetId)
{
    return context.ZapsanyPredmet
        .Where(z => z.PredmetId == predmetId)
        .Select(z => z.Student)
        .ToList();
}

IEnumerable<Predmet> PredmetyStudenta(int studentId)
{
    return context.ZapsanyPredmet
        .Where(z => z.StudentId == studentId)
        .Select(z => z.Predmet)
        .ToList();
}

// 7 
Console.WriteLine("Studenti predmetu ID 1 (BPC-IC2)");

foreach (var student in StudentiPredmetu(1))
{
    Console.WriteLine($"{student.StudentId}, {student.Jmeno} {student.Prijmeni}");
}

Console.WriteLine();

Console.WriteLine("Predmety studenta ID 1");

foreach (var predmet in PredmetyStudenta(1))
{
    Console.WriteLine($"{predmet.PredmetId}, {predmet.Zkratka}, {predmet.Nazev}");
}

Console.WriteLine();

Console.WriteLine("Predmety studenta ID 2");

foreach (var predmet in PredmetyStudenta(2))
{
    Console.WriteLine($"{predmet.PredmetId}, {predmet.Zkratka}, {predmet.Nazev}");
}

Console.WriteLine();


// 8
Console.WriteLine("Predmety a prumerna znamka");

var prumerneZnamky = context.Predmety
    .Select(p => new
    {
        p.Zkratka,
        p.Nazev,
        PrumernaZnamka = context.Hodnoceni
            .Where(h => h.PredmetId == p.PredmetId)
            .Select(h => (double?)h.HodnoceniStudenta)
            .Average()
    })
    .ToList();

foreach (var predmet in prumerneZnamky)
{
    string prumer = predmet.PrumernaZnamka.HasValue
        ? predmet.PrumernaZnamka.Value.ToString("0.00")
        : "bez hodnoceni";

    Console.WriteLine($"{predmet.Zkratka}, {predmet.Nazev}: {prumer}");
}


