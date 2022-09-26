//=======================================================
// # Задача 58 Задайте две маирицы. Напишите программу, 
// которая будет находить произведение двух матриц.
//=======================================================
// Умножать можно такие прямоугольные матрицы, в которых 
// число столбцов первой матрицы равно числу строк во второй
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

// Метод произведения двух матриц.
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    // проверка условия возможности перемножения двух матриц
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        // стандартный алгоритм произведения
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}


int[,] matrixOne = Fill2DArray(4, 4, 1, 9);
int[,] matrixTwo = Fill2DArray(4, 4, 1, 9);

PrintData("\nМатрица 1: \n");
Print2DArray(matrixOne);

PrintData("\nМатрица 2: \n");
Print2DArray(matrixTwo);

PrintData("\nПроизведение дух матриц: \n");
int[,] matrixThree = MultiplicationMatrix(matrixOne, matrixTwo);
Print2DArray(matrixThree);
