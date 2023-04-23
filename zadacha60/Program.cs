// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintArray(int[, ,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j,k]}({i},{j},{k}))| ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] FillArray(int rows, int columns,int volume, int min, int max)
{
    int[, ,] array = new int[rows, columns,volume];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < volume; k++)
            {
                array[i, j, k] = rand.Next(min, max);
               
            }
        }
    }
    return array;
}

int InNumber(string nameSpace)
{
    System.Console.Write(nameSpace);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int rows = InNumber("Введите количество строк: ");
int columns = InNumber("Введите количество столбцов: ");
int volume = InNumber("Введите объем: ");
int[, ,] array = FillArray(rows,columns,volume, 10, 100);
PrintArray(array);