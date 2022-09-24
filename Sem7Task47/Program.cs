//====================================================================
// # Задача 47 Задайте двумерный массив размером m x n, заполненный  
// случайными вещественными числами.
//====================================================================
// Задача по уроку.
PrintData("\nРешение задачи по уроку.");

// Чтение данных из консоли.
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Печать результата.
void PrintData(string line)
{
    Console.WriteLine(line);
}

// Метод заполнение двумерного
// массива вещественными числами.
double[,] Fill2DArray(int countRow, int countColumn, int downBorder, int topBorder)
{
    System.Random rand = new System.Random();
    double[,] array2D = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i,j] = Math.Round((rand.Next(downBorder, topBorder) + rand.NextDouble()), 2);
        }
    }
    return array2D;
}

// Печать двумерного массива.
void Print2DArrayDouble(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            // преобразуем значение матрицы в строку
            string num = matr[i,j].ToString();
            // находим количество пробелов для добавления в выходную строку
            int len = 5 - num.Length;
            Console.Write($"{matr[i, j]}" + " ".PadRight(len+1));
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
PrintData("");

double[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArrayDouble(arr2D);

//============================================================
// *Задача При выводе матрицы показывать каждую цифру разного 
// цвета (цветов всего 16).
//============================================================
PrintData("\n*Задача.");

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

// Печать двумерного массива с вещественными числами
// и разным цветом цифр.
void Print2DArrayDoubleColored(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            // преобразуем значение матрицы в строку
            string num = matr[i,j].ToString();
            // количество пробелов для добавления в выходную строку
            int len = 5 - num.Length;
            // красим цифры в разные цвета кроме запятых
            for (int k = 0; k<num.Length; k++)
            {
                if (Char.IsDigit(num[k]))
                {
                    Console.ForegroundColor = col[new System.Random().Next(0,16)];
                    Console.Write(num[k]);
                }
                else
                { 
                    Console.ResetColor();
                    Console.Write(num[k]);
                }

            }
            Console.Write(" ".PadRight(len+1));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

PrintData("");

Print2DArrayDoubleColored(arr2D);
