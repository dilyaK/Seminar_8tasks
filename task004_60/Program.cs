// формируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void RandomCube(int[,,] mass, int[] mas)
{
    int l=0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(2); k++)
            {
                mass[i, j, k] = mas[l];
                l++;
            }
        }
    }
}

void PrintCube(int[,,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(2); k++)
            {
                Console.Write($"{mass[i, j, k]} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] Generator(int m3)
{
    Random rnd = new Random();
    int[] a = new int[m3];
    a[0] = rnd.Next(10, 100);
    for (int i = 1; i < a.Length;)
    {
        int num = rnd.Next(10, 100); // генерируем элемент
        int j;
        // поиск совпадения среди заполненных элементов
        for (j = 0; j < i; j++)
        {
            if (num == a[j])
                break; // совпадение найдено, элемент не подходит
        }
        if (j == i)
        { // совпадение не найдено
            a[i] = num; // сохраняем элемент
            i++; // переходим к следующему элементу
        }
    }
    return a;
}

Console.WriteLine("Введите длину куба (n): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ширину куба (n): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите высоту куба (l): ");
int l = Convert.ToInt32(Console.ReadLine());

int[,,] Cube = new int[n, m, l];
int vol=n*m*l;
if(vol<91)
{
RandomCube(Cube, Generator(vol));
PrintCube(Cube);
}
else Console.WriteLine("Количество элементов позиций матрицы превышает количесво двузначных элементов");