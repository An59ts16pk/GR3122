//========================================================================
// # Задача 34 Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
//========================================================================
// Решение задачи по уроку
// Универсальный метод генерации и заполнения массива
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

// Метод выводит в консоль одномерный массив
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// Метод, принимает строку и выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Метод тестирует число на чётность
bool EvenTest(int num)
{
    return (num % 2 == 0);
}

// Метод считает количество чётных чисел в массиве
int EvenCount(int[] arr)
{
    int count = 0;
    for(int i=0; i < arr.Length; i++)
    {
        if (EvenTest(arr[i]))
        {
            count++;
        }
    }
    return count;
}

// Заполняем массив и выводим его в терминал
int[] inputArray = FillArray(20, 100, 999);
Print1DArr(inputArray);

PrintResult("Количество чётных чисел в массиве: " + EvenCount(inputArray));

//===========================================================================
// Метод сортировки массива пузырьком Вариант 1
int[] BubbleSortVariant1(int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
}

// Метод сортировки массива пузырьком Вариант 2,
// другая реализация вложенного цикла for
int[] BubbleSortVariant2(int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
    return arr;
}

// Метод вывода массива в консоль 
void Print1DArrJoin(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

// Вариант 1
int[] inputArrayV1 = FillArray(20, 100, 999);

PrintResult("\nИсходный массив: ");
Print1DArrJoin(inputArrayV1);
DateTime d1 = DateTime.Now;
BubbleSortVariant1(inputArrayV1);
Console.WriteLine(DateTime.Now - d1);
PrintResult("Массив после сортировки - метод пузырька Вариант1 : ");
Print1DArrJoin(inputArrayV1);

// Вариант 2
int[] inputArrayV2 = FillArray(20, 100, 999);

PrintResult("\nИсходный массив: ");
Print1DArrJoin(inputArrayV2);
DateTime d2 = DateTime.Now;
BubbleSortVariant2(inputArrayV2);
Console.WriteLine(DateTime.Now - d2);
PrintResult("Массив после сортировки - метод пузырька Вариант2 : ");
Print1DArrJoin(inputArrayV2);

// Вывод - Вариант 2 сортировки пузырьком работает быстрее
// примерно в 20 раз чем Вариант 1, потому что в Варианте 2
// на каждой итерации в сортировке принимают участие только
// элементы не прошедшие сортировку, после каждой итерации
// происходит уменьшение длины сортировки и перенос в конец 
// массива найденного наибольшего элемента.
// Реализация алгоритма по Вариант 2 лучше.