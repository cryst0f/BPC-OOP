double[,] data =
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

double[,] data2 =
{
    { 4, 5, 6 },
    { 1, 2, 3 },
    { 7, 8, 9 }
};

double[,] dataDeterminant =
{
    { 2, 1, 0 },
    { 3, 1, 2 },
    { 5, 1, 15 }
};

Matrix a = new Matrix(data);
Matrix b = new Matrix(data2);
Matrix c = new Matrix(data);

Matrix d = new Matrix(dataDeterminant);

Matrix sum = a + b;
Matrix min = b - a;
Matrix nas = a * b;
Matrix un = -a;


Console.WriteLine(sum);
Console.WriteLine(min);
Console.WriteLine(nas);
Console.WriteLine(un);

Console.WriteLine(a == b);
Console.WriteLine(a == c);

Console.WriteLine(a != b);
Console.WriteLine(a != c);

Console.WriteLine(d.Determinant());
