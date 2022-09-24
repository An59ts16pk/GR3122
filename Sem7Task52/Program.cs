//==============================================================
// # Задача 52 Задайте двумерный массив из целых чисел. Найдите 
// среднее арифметическое элементов в каждом столбце.
//==============================================================
// // Задача по уроку.
PrintData("\nРешение задачи по уроку.");

// Печать результата.
void PrintData(string line)
{
    Console.WriteLine(line);
}

// Метод заполнение двумерного массива
// случайными целыми числами.
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
        Console.Write("     ");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}    ");
        }
        Console.WriteLine();
    }
}

// Метод находит среднее арифметическое каждого столбца
// и возвращает одномерный массив этих значений.
double[] AverageColumn(int[,] arr2D)
{
    // одномерный массив по количеству столбцов в двумерном массиве
    double[] outArr = new double[arr2D.GetLength(1)];
    // количество значений (строк) в столбце двумерного массива
    int count = arr2D.GetLength(0);
    for(int j = 0; j<arr2D.GetLength(1); j++)
    {
        for (int i = 0; i<arr2D.GetLength(0); i++)
        {
            outArr[j] += arr2D[i, j];
        }
        outArr[j] = Math.Round((outArr[j] / count), 2);
    }
    return outArr;
}

// Метод печати одномерного массива с вещественными числами.
void Print1DArrayDouble(double[] arr)
{
    Console.Write("res: ");
    for (int i = 0; i<arr.Length; i++)
    {
        int lenA = arr[i].ToString().Length;
        int len = 5 - lenA;
        // добавляем пробелы в вывод
        Console.Write($"{arr[i]}" + " ".PadRight(len+1));
    }
    Console.WriteLine();
}

int row = new System.Random().Next(3, 12);
int column = new System.Random().Next(3, 14);
int[,] array2D = Fill2DArray(row, column, 10, 99);

PrintData("");
Print2DArray(array2D);

double[] result = AverageColumn(array2D);
Print1DArrayDouble(result);

//=======================================================
// *Задача Дополнительно вывести среднее арифметическое
// по всем диагоналям и диагонали выделить разным цветом.
//=======================================================
PrintData("\n   *Задача.\n");

// Метод находит среднее арифметическое по диагонали и
// возвращает массив этих значений.
double[] AverageDiagonal(int[,] arr2D)
{
    // количество строк
    int n = arr2D.GetLength(0);
    // количество столбцов
    int m = arr2D.GetLength(1);
    // количество диагоналей в массиве
    int countD = n + m - 1;
    // выходной массив сумм диагоналей
    double[] outArr = new double[countD];
    
    // получаем суммы диагоналей в массиве
    for (int i = -(n-1); i<m; i++)
    {
        int count = 0;
        for(int j = 0; j<n; j++)
        {
            int row = j;
            int col = i+j;
            if (row >= 0 && col >= 0 && col < m)
            {
                outArr[i + n-1] += arr2D[row, col];
                count++; 
            }
        }
        // среднее арифметическое диагоналей
        outArr[i+n-1] = Math.Round((outArr[i+n-1] / count), 2);
    }
    return outArr;
}

ConsoleColor[] colors = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.DarkMagenta,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.Blue,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};



// Метод печати двумерного массива с подсветкой
// цветом диагоналей.
void Print2DColoredDiag(int[,] arr2D)
{
    // количество строк
    int n = arr2D.GetLength(0);
    // количество столбцов
    int m = arr2D.GetLength(1);
    // количество диагоналей в массиве
    int d = n + m - 1;
        
    // печать массива 2D
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        Console.Write("     ");
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            int colorD = Math.Abs(j-i);

            Console.ForegroundColor = colors[colorD];
            Console.Write($"{arr2D[i, j]}    ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Метод печати одномерного массива с 
// цветовой подсветкой результата.
void Print1DColoredDouble(double[] arr, int n)
{
    Console.Write("res: ");
    for (int i = 0; i<arr.Length; i++)
    {
        int colorD = Math.Abs(n-i-1);
        int lenA = arr[i].ToString().Length;
        int len = 5 - lenA;
        Console.ForegroundColor = colors[colorD];
        Console.Write($"{arr[i]}" + " ".PadRight(len+1));
        Console.ResetColor();
    }
    Console.WriteLine();
}

double[] resultDiag = AverageDiagonal(array2D);

Print2DColoredDiag(array2D);
Print1DColoredDouble(resultDiag, array2D.GetLength(0));
