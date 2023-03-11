/*
Задача 57: Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 9, 9, 0,
2, 8, 0, 9
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
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

void FrequencyDictionary (int [,] array, int minV, int maxV)
{
    while (minV <= maxV)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array [i, j] == minV)
                {
                    count ++;
                }
            }
        }
        Console.WriteLine ($"{minV} meets {count} times");
        minV ++;
    }
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
FrequencyDictionary (newArray, user_min, user_max);