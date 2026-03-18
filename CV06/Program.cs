using CV06;
using System.Drawing;
using System.Runtime;


double celkovaPlocha = 0;
double celkovyPovrch = 0;
double celkovyObjem = 0;

Kruh kruh = new Kruh(5);
Kvadr kvadr = new Kvadr(4, 3, 5);
Trojuhelnik troj = new Trojuhelnik(6, 7, 5);
Jehlan jehlan = new Jehlan(3.5, 4.4, 5, 2);
Elipsa elip = new Elipsa(2.5, 6.3);
Valec valec = new Valec(3.5, 5.2);
Koule koule = new Koule(7.5);
Obdelnik obd = new Obdelnik(4.3, 5.6);

List<GrObjekt> tvary = new List<GrObjekt>() {
                kruh, kvadr, troj, jehlan, elip, valec,koule, obd
            };

foreach(var obrazec in tvary)
{
    obrazec.Kresli();

    if (obrazec is Objekt2D)
    {
        celkovaPlocha += ((Objekt2D)obrazec).SpoctiPlochu();
    }
    else if (obrazec is Objekt3D)
    {
        celkovyPovrch += ((Objekt3D)obrazec).SpoctiPovrch();
        celkovyObjem += ((Objekt3D)obrazec).SpoctiObjem();
    }
    else
    {
        Console.WriteLine("Neni 2D ani 3D objekt");
    }
}

Console.WriteLine("Celkova plocha 2D objektu {0:F4}.\nCelkovy povrch 3D objektu {1:F2}.\n" +
    "Celkovy objem 3D objektu {2:F2}.", celkovaPlocha, celkovyPovrch, celkovyObjem);
Console.ReadLine();