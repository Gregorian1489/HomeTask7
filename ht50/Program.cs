// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же 
// указание, что такого элемента нет.

Console.WriteLine("Введите позицию элемента(от 00 до 99 )");
string linex = Console.ReadLine();
int [] arr = new int[2];
for (int m = 0;m<linex.Length;m++) 
{
    arr[m] = int.Parse(Convert.ToString(linex[m]));
}
Console.WriteLine();

int line = new Random().Next(2,10);
int col =  new Random().Next(2,10);

if ((arr[0]>line)||(arr[1]>col))
{
    Console.WriteLine("Такого элемента нет");
    Console.WriteLine();
}


int[,]array = new int[line,col];

for(int i = 0;i<line;i++)
{
    for(int j = 0; j<col;j++)
    {
        array[i,j] = new Random().Next(1,10);
        if ((i == arr[0])&&(j == arr[1]))
        {
        Console.ForegroundColor = ConsoleColor.Green;
        }
        Console.Write(array[i,j]+" ");
        Console.ResetColor();
    }
    Console.WriteLine();
}
