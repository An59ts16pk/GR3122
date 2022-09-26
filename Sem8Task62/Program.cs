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
// (Хорошо заполняет квадратные и прямоугольные с небольшим
// изменением в разнице количества строк и столбцов, 
// разница примерно два. Дальше пыхтеть не стал, 
// время поджимает и задача судя по условию квадратный массив.)
int[,] SpiralFill2DArray(int row, int col)
{
    int[,] array2D = new int[row, col];
    int pet;
    int p = 2; // кол. проходов массива
    if (row <= col) pet = row;
    else pet = col;
    if (pet <= 4) p = 2;
    else
    {
        // определяем количество проходов
        // от размерности строк или столбцов
        while(pet > 4)
        {
            if (pet % 2 != 0)
            {
                p++;
            }
            pet--;
        }
    }
    
    int count = 1; //счётчик заполнения
    int i = 0; // старт заполнения строки
    int j = 0; // старт заполнения столбца
    // граница заполнения строк
    int dsi = 0;
    int dei = row-1;
    // граница заполнения столбцов
    int dsj = 0;
    int dej = col-1;
    
    while(p > 0)
    {
        // шаг 1
        while(j >= dsj && j <= dej)
        {
            array2D[i,j] = count;
            j++;
            count++;
        }
        i++;
        j--;
        // шаг 2
        while(i >= dsi && i <= dei)
        {
            array2D[i,j] = count;
            i++;
            count++;
        }
        i--;
        j--;
        // шаг 3
        while(j >= dsj && j <= dej)
        {
            array2D[i,j] = count;
            j--;
            count++;
        }
        j++;
        i--;
        // шаг 4
        while(i > dsi && i <= dei)
        {
            array2D[i,j] = count;
            i--;
            count++;
        }
                
        p--;
        i++;
        j++;
        dsi++;
        dei--;
        dsj++;
        dej--;
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
            
            Console.Write($"{matr[i, j].ToString("D2")} ");
        }
        Console.WriteLine();
    }
}

int[,] result = SpiralFill2DArray(4, 4);

PrintData("\nРезультат: \n");
Print2DArray(result);
