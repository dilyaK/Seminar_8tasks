// Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void RandomMatrix(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(1,10);
        }
    }
}

void PrintMatrix(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write("{0,6:F1}", mass[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}

Console.WriteLine("Введите количество строк матрицы A (m): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы A (n1): ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк матрицы B (n2): ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы B (k): ");
int k = Convert.ToInt32(Console.ReadLine());

int[,] A = new int[m,n1];
int[,] B = new int[n2,k];

if(n1!=n2) Console.Write("Умножить матрицы невозможно, число столбцов матрицы A должно быть равно числу строк матрицы B");
else
{
    RandomMatrix(A);
    RandomMatrix(B);
    Console.WriteLine("Матрица A:");
    PrintMatrix(A);
     Console.WriteLine("Матрица B:");
    PrintMatrix(B);
    Console.WriteLine("Матрица произведение матриц:");
    PrintMatrix(DivMatrix(A,B));
}

