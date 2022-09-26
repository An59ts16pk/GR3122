//==============================================================
// # Задача 56 Задайте прямогугольный двумерный массив. Напишите  
// программу, которая будет находить строку с наименьшей суммой
// элементов.
//==============================================================

// Печать результата.
void PrintData(string line)
{
    Console.WriteLine(line);
}

// Метод заполнение двумерного массива случайными числами.
int[,] Fill2DArray(int countRow, int countColumn, int downBorder, int topBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i,j] = rand.Next(downBorder, topBorder);
        }
    }
    return array2D;
}

// Печать двумерного массива.
void Print2DArray(int[,] matr)
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

// Метод находит строку с наименьшей суммой элементов.
int FindMinSumRow(int[,] arr2D)
{
    int minSum = int.MaxValue;
    int indexRow = 0;
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            sum += arr2D[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            indexRow = i;
        }
    }
    return indexRow;
}

int[,] array2D = Fill2DArray(5, 8, 10, 99);
PrintData("Исходный массив: \n");
Print2DArray(array2D);
int result = FindMinSumRow(array2D);
PrintData($"Строка {result+1} массива имеет минимальную сумму элементов.");
