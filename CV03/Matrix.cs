using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Matrix
{
    double[,] matrix;
    string result = "";

    public Matrix(double[,] matrix)
    {
        this.matrix = matrix;
    }

    private int RowSize
    {
        get {  return matrix.GetLength(0); }
    }

    private int ColumnSize
    {
        get { return matrix.GetLength(1); }
    }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.ColumnSize != b.ColumnSize || a.RowSize != b.RowSize)
        {
            throw new Exception("Incompatible matrix size");
        }

        double[,] resultMatrix = new double[a.RowSize, b.ColumnSize];

        for (int i = 0; i < a.RowSize; i++)
        {
            for (int j = 0; j < b.RowSize; j++)
            {
                resultMatrix[i, j] = a.matrix[i, j] + b.matrix[i, j];
            }
        }
        return new Matrix(resultMatrix);
    }

    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.ColumnSize != b.RowSize)
        {
            throw new Exception("Incompatible matrix size");
        }
        double[,] resultMatrix = new double[a.RowSize, b.ColumnSize];

        for (int rowIndex = 0; rowIndex < a.RowSize; rowIndex++)
        {
            for (int columnIndex = 0; columnIndex < b.ColumnSize; columnIndex++)
            {
                double sum = 0;
                for (int sumIndex = 0; sumIndex < a.ColumnSize; sumIndex++)
                {
                    sum += a.matrix[rowIndex, sumIndex] * b.matrix[sumIndex, columnIndex];
                }
                resultMatrix[rowIndex, columnIndex] = sum;
            }
        }

        return new Matrix(resultMatrix);
    }
    
    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.ColumnSize != b.ColumnSize || a.RowSize != b.RowSize)
        {
            throw new Exception("Incompatible matrix size");
        }

        double[,] resultMatrix = new double[a.RowSize, b.ColumnSize];

        for (int i = 0; i < a.RowSize; i++)
        {
            for (int j = 0; j < b.RowSize; j++)
            {
                resultMatrix[i, j] = a.matrix[i, j] - b.matrix[i, j];
            }
        }
        return new Matrix(resultMatrix);
    }

    public static bool operator ==(Matrix a, Matrix b)
    {
        if (a.ColumnSize != b.ColumnSize || a.RowSize != b.RowSize)
        {
            return false;
        }

        for (int i = 0; i < a.ColumnSize; i++)
        {
            for (int j = 0; j < a.RowSize; j++)
            {
                if (a.matrix[i, j] != b.matrix[i, j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static bool operator !=(Matrix a, Matrix b)
    {
        if (a.ColumnSize != b.ColumnSize || a.RowSize != b.RowSize)
        {
            return true;
        }

        for (int i = 0; i < a.ColumnSize; i++)
        {
            for (int j = 0; j < a.RowSize; j++)
            {
                if (a.matrix[i, j] != b.matrix[i, j])
                {
                    return true;
                }
            }
        }
        return false;
    }

    public static Matrix operator -(Matrix a)
    {
        double[,] resultMatrix = new double[a.RowSize, a.ColumnSize];

        for (int i = 0; i < a.RowSize; i++)
        {
            for (int j = 0; j < a.RowSize; j++)
            {
                resultMatrix[i, j] = a.matrix[i, j] * (-1);
            }
        }
        return new Matrix(resultMatrix);
    }
    public override string ToString()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0;  j < matrix.GetLength(1); j++)
            {
                //result += string.Format("{0,10:F2}", matrix[i,j]);
                result += $"{matrix[i, j],10:F2}";
            }
            result += "\n";
        }
        return result;
    }

    public double Determinant()
    {
        if (RowSize != ColumnSize)
        {
            throw new Exception("Incompatible matrix size");
        }

        if (RowSize > 3)
        {
            throw new Exception("Not supported");
        }

        if (RowSize == 1)
        {
            return matrix[0, 0];
        }

        if (RowSize == 2)
        {
            return matrix[0, 0] * matrix[1, 1]
                 - matrix[0, 1] * matrix[1, 0];
        }

        return
            matrix[0, 0] * matrix[1, 1] * matrix[2, 2] +
            matrix[1, 0] * matrix[2, 1] * matrix[0, 2] +
            matrix[2, 0] * matrix[0, 1] * matrix[1, 2] -
            matrix[0, 2] * matrix[1, 1] * matrix[2, 0] -
            matrix[1, 2] * matrix[2, 1] * matrix[0, 0] -
            matrix[2, 2] * matrix[0, 1] * matrix[1, 0];
    }
}
   
