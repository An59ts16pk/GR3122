//=======================================================
// # Задача 62 Напишите программу, которая заполнит 
// спирально массив 4 на 4. Например, на выходе 
// получается такой массив:  01 02 03 04
//                           12 13 14 05
//                           11 16 15 06
//                           10 09 08 07
//=======================================================
// Печать результата.
void PrintData(string line)
{
    Console.WriteLine(line);
}

// Метод спирального заполнение двумерного массива числами.
int[,] SpiralFill2DArray(int row, int col)
{
    int[,] arr2D = new int[row, col];
    int n = row; // строки
    int m = col; // столбцы
    // границы заполнения
    int ibeg = 0, ifin = 0, jbeg = 0, jfin = 0;

    int count = 1; // счётчик заполнения
    int i = 0; // старт строк
    int j = 0; // старт столбцов

    while (count <= n * m)
    {
        arr2D[i,j] = count;
        if (i == ibeg && j < m - jfin - 1)
            j++;
        else if (j == m - jfin - 1 && i < n - ifin - 1)
            i++;
        else if (i == n - ifin - 1 && j > jbeg)
            j--;
        else
            i--;

        if ((i == ibeg + 1) && (j == jbeg) && (jbeg != m - jfin - 1))
        {
            ibeg++;
            ifin++;
            jbeg++;
            jfin++;
        }
        count++;
    }
    return arr2D;
}

// Печать двумерного массива.
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            
            Console.Write($"{matr[i, j].ToString("D2")} ");
        }
        Console.WriteLine();
    }
}

int[,] result = SpiralFill2DArray(6, 9);

PrintData("\nРезультат: \n");
Print2DArray(result);
