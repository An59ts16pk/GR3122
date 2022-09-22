//====================================================================
// # Задача 49 Задайте двумерный массив. Найдите элементы, у которых  
// оба индекса чётные, и замените эти элементы на их квадраты.
//====================================================================
// // Чтение данных из консоли
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

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

// // Заполняем массив случайными числами
// void Fill2DArray(int[,] matr, int min, int max)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(min, max + 1);
//         }
//     }
// }

// // Делаем квадраты
// void Change2DArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             // это решение будет работать в два раза медленнее,
//             // потому что надо пробегать весь массив
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matr[i, j] = (int)Math.Pow(matr[i, j], 2);
//             }

//         }
//     }
// }

// int m = ReadData("Введите количество столбцов: ");
// int n = ReadData("Введите количество строк: ");
// int[,] matrix = new int[m, n];

// Fill2DArray(matrix, 10, 99);
// Print2DArray(matrix);
// Change2DArray(matrix);

// Console.WriteLine();
// Print2DArray(matrix);


// Печать 2D массива.
void Print2DArr(int[,] arr, string message = "Массив: ")
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Генерация случайного двумерного массива.
int[,] Gen2DArr(int arrLen, int arrDepth, int arrMin, int arrMax)
{
    int[,] arr = new int[arrLen, arrDepth];
    Random rnd = new Random();

    if (arrMin > arrMax)
    {
        int temp = arrMax;
        arrMax = arrMin;
        arrMin = temp;
    }

    for (int i = 0; i < arrLen; i++)
    {
        for (int j = 0; j < arrDepth; j++)
        {
            arr[i, j] = rnd.Next(arrMin, arrMax);
        }
    }
    return arr;
}

// Возведение в квадрат по чётным индексам
int[,] EvenToSquere(int[,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i+=2)
    {
        for (int j = 1; j < arr.GetLength(1); j+=2)
        {
            arr[i, j] *= arr[i, j];
        }        
    }
    return arr;
}

// Делаем квадраты
void Change2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matr[i, j] = (int)Math.Pow(matr[i, j], 2);
            }

        }
    }
}

int[,] arr = Gen2DArr(10, 15, 10, 99);
Print2DArr(arr);
Console.WriteLine();
Console.WriteLine();

int[,] arr2d_1 = new int[10, 15];
int[,] arr2d_2 = new int[10, 15];

arr2d_1 = (int[,])arr.Clone();
arr2d_2 = (int[,])arr.Clone();

DateTime d1 = DateTime.Now;
arr2d_1 = EvenToSquere(arr2d_1);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
Change2DArray(arr2d_2);
Console.WriteLine(DateTime.Now - d2);

//Print2DArr(EvenToSquere(arr));
