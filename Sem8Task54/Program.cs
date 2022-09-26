//==============================================================
// # Задача 54 Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
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

// Метод сортировкм строк по убыванию.
int[,] Array2DSortedRow(int[,] arr2D)
{
    for (int i = 0; i<arr2D.GetLength(0); i++)
    {
        List<int> row = new List<int>();
        for (int j = 0; j<arr2D.GetLength(1); j++)
        {
            row.Add(arr2D[i,j]);
        }
        row.Sort();
        row.Reverse();
        for(int j = 0; j<arr2D.GetLength(1); j++)
        {
            arr2D[i,j] = row[j];
        }
    }
    return arr2D;
} 

int[,] array2D = Fill2DArray(5, 8, 10, 99);
PrintData("Исходный массив: \n");
Print2DArray(array2D);
PrintData("\nОтсортированный массив: \n");
int[,] res = Array2DSortedRow(array2D);
Print2DArray(res);
