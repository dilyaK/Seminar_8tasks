

int size = 4;
int[,] array = new int[size, size];
int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = size;

for (int i = 0; i < array.Length; i++)// length âîçâðàùàåò êîë-âî ýëåìåíòîâ â ìàññèâå, ò.å. size * size
{
array[row, col] = i + 1;
if (--gran == 0)
{
gran = size * (dirChanges % 2) + size * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
int temp = dx;
dx = -dy;
dy = temp;
dirChanges++;
}
col += dx;
row += dy;
}
for(int i = 0; i < size; ++i)
{
for(int j = 0; j < size; ++j)
{
Console.Write(array[i, j] + "\t");
}
Console.WriteLine();
}