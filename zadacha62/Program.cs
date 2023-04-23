// Задача 62. Напишите программу, которая заполнит спирально массив . Размер вводит юзер
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= rows * columns)
    {
        array[i, j] = num;
        if (i <= j + 1 && i + j < columns - 1)
            ++j;
        else if (i < j && i + j >= rows- 1)
            ++i;
        else if (i >= j && i + j > columns - 1)
            --j;
        else
            --i;
        ++num;
    }
    return array;
}
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

int InNumber(string nameSpace)
{
    System.Console.Write(nameSpace);
    int num = int.Parse(Console.ReadLine());
    return num;
}

Console.Clear();
int rows = InNumber("Введите количество строк: ");
int columns = InNumber("Введите количество столбцов: ");
int[,] array = FillArray(rows, columns);
PrintArray(array);
System.Console.WriteLine();