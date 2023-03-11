/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

void RowMinSum (int [,] array)
{
    int k = 0;
    int sum = 0;
    int minSum = 0;
    int rowMinSum = 0;
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSum += array [k, j];
    }
    
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array [i, j];
        }
        if (sum < minSum)
            {
                minSum = sum;
                rowMinSum += i;
            }
    }
    Console.WriteLine ($"{rowMinSum} row with minimal elements");
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
RowMinSum (newArray);