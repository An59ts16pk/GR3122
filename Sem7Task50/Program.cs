//====================================================================
// # Задача 50 Напишите программу, которая на вход принимает позиции  
// элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет. 
//====================================================================
// Задача по уроку.
PrintData("\nРешение задачи по уроку.");

// Чтение данных из консоли.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата.
void PrintData(string line)
{
    Console.WriteLine(line);
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

// Метод значение в двумерном массиве по его позиции.
int FindElem(int m, int n, int[,]matr)
{
    if (m < matr.GetLength(0) && n < matr.GetLength(1))
    {
        return matr[m, n];
    }
    else return -1;
}

// Метод вывода позиции элемента и его значение в массиве.
void PrintResult(int res, int m, int n)
{
    if (res < 0)
    {
        Console.WriteLine($"\nЭлемента с позицией {m}x{n} в массиве нет.");
    }
    else
    {
        Console.WriteLine($"\nЗначение элемента с позицией {m}x{n}: {res}");
    }
}

int row = new System.Random().Next(3, 12);
int column = new System.Random().Next(3, 14);
int[,] arr2D = Fill2DArray(row, column, 10, 99);
PrintData("");
Print2DArray(arr2D);

PrintData("\nВведите индексы позиции для поиска элемента в двумерном массиве.");
int pozM = ReadData("Введите индекс позиции строки m: ");
int pozN = ReadData("Введите индекс позиции столбца n: ");

int result = FindElem(pozM, pozN, arr2D);
PrintResult(result, pozM, pozN);
//====================================================================
// Заполнить массив числами Фибоначчи, распечатать массив; найти
// в массиве заданную цифру, распечатать массив подсветив найденную
// цифру цветом, если такой нет, то ничего не подсвечивать. 
//====================================================================
PrintData("\n   *Задача.\n");

// Метод заполняет двумерный массив числами Фибоначчи.
int[,] Fill2DArrayFibonacci(int countRow, int countColumn)
{
    int[,] array2D = new int[countRow, countColumn];
    int ferst = 0;
    int last = 1;
    int buf = 0;
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i,j] = ferst;
            buf = ferst + last;
            ferst = last;
            last = buf;
        }
    }
    return array2D;
}

// Метод ищет заданное число Фибоначчи и
// возвращает его, если находит.
int FindFibonacci(int numF, int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            if (arr2D[i,j] == numF) return numF;
        }
    }
    return -1;
}

// Метод выводит массив Фибоначчи на экран
// с подсветкой цветом найденого элемента.
void Print2DArrayFibColored(int numF, int[,]arr2D)
{
    // длина максимального значения Фибоначчи
    string lenMax = arr2D[arr2D.GetLength(0)-1, arr2D.GetLength(1)-1].ToString();
    if (numF >= 0)
    {
        Console.WriteLine();
        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            for (int j = 0; j < arr2D.GetLength(1); j++)
            {
                string lenFib = arr2D[i, j].ToString();
                // находим количество добавляемых пробелов в результат
                int lenF = lenMax.Length - lenFib.Length;
                if (arr2D[i, j] == numF)
                {
                    // подсвечиваем цветом найденный элемент
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{arr2D[i, j]}" + " ".PadRight(lenF+1));
                    Console.ResetColor();
                }
                else Console.Write($"{arr2D[i, j]}" + " ".PadRight(lenF+1));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    else PrintData($"\nТакого числа Фибоначчи в масииве нет!");
}

int rowF = new System.Random().Next(3, 10);
int columnF = new System.Random().Next(3, 10);

int[,] arr2DFib = Fill2DArrayFibonacci(rowF, columnF);
Print2DArray(arr2DFib);

int numFib = ReadData("\nВведите число Фибоначчи для поиска в массиве: ");
int resultFib = FindFibonacci(numFib, arr2DFib);

Print2DArrayFibColored(resultFib, arr2DFib);
