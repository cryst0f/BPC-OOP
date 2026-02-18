using System.Numerics;

/*Complex number = new Complex(1.0, 4.0);
Complex number2 = new Complex(2.0, 1.0);
Console.WriteLine(number);
Console.WriteLine(number.Sdruzene());

Console.WriteLine(number != number2);*/

Complex a = new Complex(1.0, 2.0);
Complex b = new Complex(1.0, 2.0);
Complex c = new Complex(1.0, 3.0);


TestComplex.Test(new Complex(3.0, 5.0), new Complex(1.0, 3.0) + new Complex(2.0, 2.0), "+");
TestComplex.Test(new Complex(3.0, 5.0), new Complex(1.0, 3.0) + new Complex(2.0, 2.0), "-");
TestComplex.Test(new Complex(-25.0, 49.0), new Complex(5.0, -3.0) * new Complex(-8.0, 5.0), "*");
TestComplex.Test(new Complex(3.0, 5.0), new Complex(1.0, 3.0) + new Complex(2.0, 2.0), "/");
TestComplex.Test(new Complex(-3.0, -5.0), -new Complex(3.0, 5.0), "unarni operator -");


Console.WriteLine(new Complex(1.0, 2.0) == new Complex(1.0, 2.0));
Console.WriteLine(new Complex(1.0, 2.0) == new Complex(1.0, 3.0));

Console.WriteLine(new Complex(1.0, 2.0) != new Complex(1.0, 2.0));
Console.WriteLine(new Complex(1.0, 2.0) != new Complex(1.0, 3.0));

Console.WriteLine(-new Complex(1.0, 2.0));

Console.WriteLine("Originalni: {0}, Sdruzene: {1}",a,a.Sdruzene());
Console.WriteLine("Modul: {0}",a.Modul());
Console.WriteLine("Argument: {0}",a.Argument());

