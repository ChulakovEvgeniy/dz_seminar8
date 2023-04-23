// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

void SelectionSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            for (int m = 0; m < array.GetLength(1)-1; m++)
            {
                if (array[i, m] > array[i, m + 1])
                {
                    int temp = array[i, m];
                    array[i, m ] = array[i, m +1];
                    array[i, m +1 ] = temp;
                }
            }
        }
    }
}

Console.Clear();
int rows = InNumber("Введите количество строк: ");
int columns = InNumber("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
FillArray(array, 1, 10);
PrintArray(array);
System.Console.WriteLine();
SelectionSort(array);
PrintArray(array);