//========================================================================
// # Задача 38 Задайте массив вещественных случайными числами. 
// Найдите разницу между максимальным и минимальным элементом массива.
//========================================================================
// Основное решение задачи.
// Универсальный метод генерации и заполнения массива
double[] FillArrayDouble(int length, int downBorder, int topBorder)
{
    Random rand = new Random();
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(
            (rand.Next(downBorder, topBorder) + rand.NextDouble()), 2);
    }
    return array;
}

// Метод вывода массива в консоль 
void Print1DArrJoinDouble(double[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

// Метод, принимает строку и выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Метод нахождения разницы между max и min
// элементами массива
double DifferenceMaxMinDouble(double[] arr)
{
    double max = int.MinValue;
    double min = int.MaxValue;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return (max - min);
}

double[] outArr = FillArrayDouble(10, 0, 10);
PrintResult("\nМассив вещественных чисел: ");
Print1DArrJoinDouble(outArr);
DateTime d1 = DateTime.Now;
double res = Math.Round(DifferenceMaxMinDouble(outArr), 2);
Console.WriteLine(DateTime.Now - d1);
PrintResult("    Разница между max и min элементом массива: " + res);
//==================================================================
// Дополнительное решение с двумя методами сортировки.
// Универсальный метод генерации и заполнения массива
int[] FillArray(int length, int downBorder, int topBorder)
{
    Random rand = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(downBorder, topBorder);
    }
    return array;
}

// Метод вывода массива в консоль 
void Print1DArrJoin(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

// Метод сортировки - сортировка вставками.
void InsertionSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int j;
        int temp = arr[i];
        for (j = i - 1; j >= 0; j--)
        {
            if (arr[j] < temp) break;
            arr[j + 1] = arr[j];
        }
        arr[j + 1] = temp;
    }
}

// Метод сортировки - сортировка подсчётом
void CountingSort(int[] arr, int topBord)
{
    int maxElement = topBord;
    int[] temp = new int[maxElement + 1];
    for (int i = 0; i < maxElement + 1; i++)
    {
        temp[i] = 0;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        temp[arr[i]]++;
    }
    for (int i = 0, j = 0; i <= maxElement; i++)
    {
        while (temp[i] > 0)
        {
            arr[j] = i;
            j++;
            temp[i]--;
        }
    }
}

// Метод разницы между max и min
int DiffMaxMin(int[] arr)
{
    return (arr[arr.Length-1] - arr[0]);
}

PrintResult("\nДополнительная задача с двумя методами сортировки.");
int topBorder = 100;

int[] arrayInser = FillArray(10, 10, topBorder);
PrintResult("\nИсходный массив:");
Print1DArrJoin(arrayInser);
PrintResult("Сортировка методом вставки:");

DateTime d2 = DateTime.Now;
InsertionSort(arrayInser);
PrintResult("Разница max - min сортированного массива: " + DiffMaxMin(arrayInser));
Console.WriteLine(DateTime.Now - d2);

Print1DArrJoin(arrayInser);

int[] arrayCount = FillArray(10, 10, topBorder);
PrintResult("\nИсходный массив:");
Print1DArrJoin(arrayCount);
PrintResult("Сортировка методом подсчёта:");

DateTime d3 = DateTime.Now;
CountingSort(arrayCount, topBorder);
PrintResult("Разница max - min сортированного массива: " + DiffMaxMin(arrayCount));
Console.WriteLine(DateTime.Now - d3);

Print1DArrJoin(arrayCount);

// Самые долгие вычисления былм с вещественными числами нахождение max - min
// Самое быстрое нахождение max - min в отсортированном массиве
// у метода сортировки - Сортировка методом подсчёта, но на разных значениях
// массива скорость работы гуляет или всё же примерно одинаково или бывает 
// метод вставки побеждает. Но у меня для каждой сортировки разные массивы.
