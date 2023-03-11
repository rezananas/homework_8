/*
Задача 58:(дополнительная) Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int [,] Multi2Array (int [,] array1, int [,] array2, int row1, int column2)
{
    int [,] newArray = new int [row1, column2];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < newArray.GetLength(1); k++)
            {
                sum += array1 [i, k] * array2 [k, j];
            }
            newArray [i, j] = sum;
        }
    }
    return newArray;
}

Console.Write ("Input count of rows of first array: ");
int row1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input count of columns of first array and rows of second array: ");
int column1_row2 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input count of columns of second array: ");
int column2 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input minimal value: ");
int user_min = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input maximal value: ");
int user_max = Convert.ToInt32 (Console.ReadLine());

int [,] array1 = Create2dArray (row1, column1_row2, user_min, user_max);
Show2dArray (array1);
int [,] array2 = Create2dArray (column1_row2, column2, user_min, user_max);
Show2dArray (array2);
int [,] newArray = Multi2Array (array1, array2, row1, column2);
Show2dArray (newArray);