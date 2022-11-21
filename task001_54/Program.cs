// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
Random rand = new Random();
for(int i = 0; i < n; ++i)
{
for(int j = 0; j < m; ++j)
{
array[i,j] = rand.Next(1, 21);
Console.Write(array[i,j] + "\t");
}
Console.WriteLine();
}

for (int currentArray = 0; currentArray < n; ++currentArray)
{
for (int i = 0; i < m; ++i)
{
for (int j = 0; j < m - 1 - i; ++j)
{
if (array[currentArray, j] < array[currentArray, j + 1])
{
int temp = array[currentArray, j];
array[currentArray, j] = array[currentArray, j + 1];
array[currentArray, j + 1] = temp;
}
}
}
}

Console.WriteLine("here");
for(int i = 0; i < n; ++i)
{
for(int j = 0; j < m; ++j)
{
Console.Write(array[i,j] + "\t");
}
Console.WriteLine();
}