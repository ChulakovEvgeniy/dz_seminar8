// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(min, max);
        }
    }
}

int InNumber(string nameSpace)
{
    System.Console.Write(nameSpace);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void Sum(int[,] matr)
{
    int minI = 0;
    int sum = 0;
    for ( int i = 0; i < matr.GetLength(1); i++)
    {
        sum += matr[0, i];
        minI = 1;
    }
    int sumRows = sum;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        if (sum < sumRows) 
        {
            minI = i+1;
            sumRows = sum;
        }
    }
    System.Console.WriteLine($"строка: {minI} имееет самую маленькую сумму элементов: {sumRows}");
}

Console.Clear();
int rows = InNumber("Введите количество строк: ");
int columns = InNumber("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
FillArray(array, 1, 10);
PrintArray(array);
System.Console.WriteLine();
Sum(array);
