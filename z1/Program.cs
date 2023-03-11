/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int [,] Create2dArray (int row, int column, int minV, int maxV)
{
    int [,] createdArray = new int [row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            createdArray [i, j] = new Random().Next(minV, maxV + 1);
        }
    }
    return createdArray;
}

void Show2dArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array [i, j] + " ");
        }
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] SortMaxMin (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array [i, k] < array [i, k + 1])
                {
                    int temp = array [i, k + 1];
                    array [i, k + 1] = array [i, k];
                    array [i, k] = temp;
                }
            }
        }
    }
    return array;
}

Console.Write ("Input count of rows: ");
int user_rows = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input count of columns: ");
int user_columns = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input minimal value: ");
int user_min = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input maximal value: ");
int user_max = Convert.ToInt32 (Console.ReadLine());

int [,] newArray = Create2dArray (user_rows, user_columns, user_min, user_max);
Show2dArray (newArray);
Show2dArray (SortMaxMin (newArray));