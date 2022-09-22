//====================================================================
// # Задача 46 Задайте двумерный массив размером m x n, заполненный  
// случайными целыми числами.
//====================================================================
// Метод считывания данных пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// // печать результата
// void PrintData(string prefix, string data) //разбили на две части вывод в консоль
// {
//     Console.WriteLine(prefix + data); //сначала выводим prefix + а потом данные data\
// }

// Универсальный метод генерации и заполнение двумерного массива случайными числами
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    //   0 1 2 3
    // 0 x
    // 1       y
    // 2
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i,j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

// // Печать двумерного массива
// void Print2DArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int row = ReadData("Введите количество строк: ");
// int column = ReadData("Введите количество столбцов: ");
// // границы значений задаются включительно (10, 99)
// int[,] arr2D = Fill2DArray(row, column, 10, 99);
// Print2DArray(arr2D);
//============================================================

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

// Печать двумерного массива цветом
void Print2DArrayColored(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            //Console.ForegroundColor = ConsoleColor.Blue;
            // задаём индекс обращения к массиву цветов как случайное число
            Console.ForegroundColor = col[new System.Random().Next(0,16)];
            Console.Write($"{matr[i, j]} ");
            Console.ResetColor(); 
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] arr2D = Fill2DArray(row,column,10,99);
Print2DArrayColored(arr2D);
