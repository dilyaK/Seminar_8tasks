// формируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int n, m, o;
Console.WriteLine("Axle size Ox");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Axle size Oy");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Axle size Oz");
o = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[n,m,o];
Random rand = new Random();
for(int i =0; i < array.GetLength(0); ++i)
{
for(int j =0; j < array.GetLength(1); ++j)
{
for(int k =0; k < array.GetLength(2); ++k)
{
array[i, j, k] = rand.Next(1, 21);
Console.Write(array[i, j, k] + string.Format("({0},{1},{2}) ", i, j, k));
}
Console.WriteLine();
}
}