// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] GenerateArray(int row, int col)
{
    int[,] array = new int[row, col];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
    }
    System.Console.WriteLine();
}

int SearchMinSumInRow(int[,] array)
{

    
    int minSum = 0;
    int result = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    { 
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i < 1) 
        {
            minSum = sum; // задаем минимальную сумму только на первом проходе
        }

        if (sum < minSum)
        {
            result++;
            minSum = sum;
        }
        
    }
    return result+1;
}


int[,] matrix = GenerateArray(4, 4);
PrintArray(matrix);
int row = SearchMinSumInRow(matrix);
System.Console.WriteLine();
System.Console.WriteLine($"В строке {row} наименьшая сумма элементов");