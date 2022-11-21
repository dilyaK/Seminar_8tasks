// Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int n1 = 0, m1 = -1, n2 = 0, m2 = 0;;
while(m1 != n2)
{
Console.Write("Enter N1: ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter M1: ");
m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N2: ");
n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter M2: ");
m2 = Convert.ToInt32(Console.ReadLine());
if(m1 != n2)
{
Console.WriteLine("M1 should be equal to N2");
}
}
int[,] array1 = new int[n1, m1];
int[,] array2 = new int[n2, m2];
int[,] result = new int[n1, m2];
Random rand = new Random();
Console.WriteLine("Matrix 1:");
for(int i = 0; i < n1; ++i)
{
for(int j = 0; j < m1; ++j)
{
array1[i,j] = rand.Next(1, 21);
Console.Write(array1[i,j] + "\t");
}
Console.WriteLine();
}
Console.WriteLine("Matrix 2:");
for(int i = 0; i < n2; ++i)
{
for(int j = 0; j < m2; ++j)
{
array2[i,j] = rand.Next(1, 21);
Console.Write(array2[i,j] + "\t");
}
Console.WriteLine();
}
Console.WriteLine("Resul matrix:");
for (int i = 0; i < n1; i++)
{
for (int j = 0; j < m2; j++)
{
for (int k = 0; k < n2; k++)
{
result[i,j] += array1[i,k] * array2[k,j];
}
Console.Write(result[i,j] + "\t");
}
Console.WriteLine();
}