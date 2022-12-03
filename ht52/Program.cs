// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк массива");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int col = Convert.ToInt32(Console.ReadLine());
int[,]array = new int[line,col];
double sum = 0;
double result = 0;

for(int i = 0;i<line;i++)
{
    for(int j = 0; j<col;j++)
    {
        array[i,j] = new Random().Next(1,10);
        Console.Write(array[i,j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.Write("Среднее арифметическое каждого столбца: ");
for(int j = 0;j<col;j++)
{
    for(int i = 0; i<line;i++)
    {
        sum = sum + array[i,j];
        result = sum/col;
    }
    Console.Write(Math.Round(result,2)+" | ");
    sum = 0;
}

