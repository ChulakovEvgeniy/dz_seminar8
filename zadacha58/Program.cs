// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] Composition(int[,] matr, int[,] matr2)
{
    int[,] newArray = new int[matr.GetLength(0), matr2.GetLength(1)];
    if (matr.GetLength(0) == matr2.GetLength(1))
    {
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                newArray[i, j] = 0;
                {
                    for (int k = 0; k < matr.GetLength(0); k++)
                    {
                        newArray[i, j] += matr[k, j] * matr2[i, k];
                    }
                }
            }
        }
    }
    return newArray;
}




Console.Clear();
int rows = InNumber("Введите количество строк: ");
int columns = InNumber("Введите количество столбцов: ");
int rows2 = InNumber("Введите количество строк: ");
int columns2 = InNumber("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
int[,] array2 = new int[rows2, columns2];
FillArray(array, 1, 5);
PrintArray(array);
System.Console.WriteLine();
FillArray(array2, 1, 5);
PrintArray(array2);
System.Console.WriteLine();
int[,] compArray = Composition(array, array2);
PrintArray(compArray);