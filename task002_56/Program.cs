// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
//строки с наименьшей суммой элементов: 1 строка

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

int max_sum = 0, number_of_str = 0;
for(int j = 0; j < m; ++j)
{
max_sum += array[0, j];
}
for(int i = 1; i < n; ++i)
{
int sum = 0;
for(int j = 0; j < m; ++j)
{
sum += array[i, j];
}
if (sum > max_sum)
{
max_sum = sum;
number_of_str = i;
}
}

Console.WriteLine("Row with the smallest sum of elements: " + number_of_str);