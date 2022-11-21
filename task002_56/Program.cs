// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SummStrk(int[,] mass)
{
    int m = 0;
    int[] massiv = new int[mass.GetLength(0)];
    int sum;
    while (m < mass.GetLength(0)) // Психолгически удобнее использовать while
    {
        sum =0;
        for (int i = 0; i < mass.GetLength(1); i++)
        {
            sum += mass[m, i];
        }
        massiv[m] =sum; 
        m++;
    }
    return massiv;
}

int ScanerMin(int[]mass) // сканер не учитывает, что могут быть одинаковые значения
{
    int imin = 0;
    for(int i=0; i<mass.Length; i++)
    {
        if(mass[i]<mass[imin]) imin = i;
    }
    return imin+1;
}

void Vyvod(int[] mass)
{
    Console.WriteLine("Суммы строк:");
    for (int j = 0; j < mass.Length; j++)
    {
        Console.Write("{0,6:F1}", mass[j]);
    }
    Console.WriteLine();
}

Console.WriteLine("Введите количество строк матрицы (n): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы (n): ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

RandomMatrix(matrix);
PrintMatrix(matrix);
Vyvod(SummStrk(matrix));
Console.Write("Наименьшая сумма элементов в строке: {0}", ScanerMin((SummStrk(matrix))));
