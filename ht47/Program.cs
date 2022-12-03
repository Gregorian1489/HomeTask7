// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк массива");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int col = Convert.ToInt32(Console.ReadLine());

double[,]array = new double[line,col];
Random rand = new Random();

for(int i = 0;i<line;i++)
{
    for(int j = 0; j<col;j++)
    {
        array[i,j] = rand.Next(-100, 100) + rand.NextDouble();
        Console.Write("{0,7}",Math.Round(array[i,j],2));
    }
    Console.WriteLine();
}