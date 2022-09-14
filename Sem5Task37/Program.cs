//========================================================================
// # Задача 37 Найдите произведение пар чисел в одномерном массиве. Парой
// считается первый и последний элемент, второй и предпоследний и т. д.
// Результат запишите в новом массиве.
//========================================================================
// // Вариант 
// // Заполняем массив
// int[] GenArray(int arrLength, int start, int stop)
// {
//     int[] array = new int[arrLength];
//     Random ren = new Random();

//     for (int i = 0; i < arrLength; i++)
//     {
//         array[i] = ren.Next(start, stop + 1);
//     }
//     return array;
// }

// // печатаем массив
// void PrintArray(int[] arr)
// {
//     Console.Write("[" + arr[0] + ", ");
//     for (int i = 1; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.Write(arr[arr.Length - 1] + "]");
//     Console.WriteLine();
// }

// // считаем числа в массиве
// int[] MultTask(int[] arr)
// {
//     int[] arrMult = new int[arr.Length/2];
//     for (int i = 0; i < arr.Length/2; i++)
//     {
//         arrMult[i] = arr[i] * arr[arr.Length-1 -i];
//     }
//     return arrMult;
// }

// int[] arr = GenArray(50, 1, 1000);

// PrintArray(arr);
// int[] outArr = MultTask(arr);
// PrintArray(outArr);

// Вариант Михаил
// Универсальный метод генерации и заполнение массива
int[] FillArray(int length, int topBorder, int downBorder)
{
    Random rand = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(topBorder, downBorder + 1);
    }
    return array;
}

// подсчитывает произведение пар чисел в одномерном массиве
int[] MultiOfPairsOfNumbers(int[] array)
{   
    int[] outArray = new int[(int)array.Length/2];
    for (int i = 0; i < outArray.Length; i++)
    {
        outArray[i] = array[i] * array[array.Length - i -1];
    }
    return outArray;
}
// вывод массив
void Print1DArray(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

int[] array = FillArray(10, 0, 30);
Print1DArray(array);
Print1DArray(MultiOfPairsOfNumbers(array));
