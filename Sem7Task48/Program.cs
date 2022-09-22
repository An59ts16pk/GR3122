//====================================================================
// # Задача 48 Задайте двумерный массив размером m x n, каждый  
// элемент в массиве находится по формуле: A(m n) = m + n.
// Выведите полученный массив на экран.
//====================================================================
// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Печать двумерного массива
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

// Заполняем массив по формуле A(m n) = m + n
int[,] Fill2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
        }
    }
    return matr;
}

int m = ReadData("Введите количество столбцов");
int n = ReadData("Введите количество строк");
int[,] matrix = new int[m, n];

matrix = Fill2DArray(matrix);
Print2DArray(matrix);
