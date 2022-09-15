//========================================================================
// # Задача 36 Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
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

// Метод вывода массива в консоль 
void Print1DArrJoin(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

// Метод, принимает строку и выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Метод нахождения суммы значений на нечётных позициях
int NotEvenSumPos(int[] arr)
{
    int sum = 0;
    for(int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

// Заполняем массив и выводим его в терминал
int[] inputArray = FillArray(20, 1, 10);
Print1DArrJoin(inputArray);

PrintResult("Сумма элементов на нечётных позициях: " + NotEvenSumPos(inputArray));
//================================================================================
// Доп. задача. Вывести все пары чисел с одинаковыми значениями.
// Метод тест наличия значения в массиве
bool TestValue(int value, int[] arr)
{
    foreach(int item in arr)
    {
        if (item == value)
        return true;
    }
    return false;
}

// Метод нахождения значений, которые имеют 
// одинаковые значения (повторяются один или 
// более раз) в исходном массиве, и
// возвращает массив этих значений
int[] SameValues(int[] arr)
{
    // создаём пустой выходной массив и индекс
    // переменную для него
    int[] outArr = new int[0];
    int index = 0;
    // двойной цикл for для нахождения повторяющихся значений 
    for (int i=0; i<arr.Length-1; i++)
    {
        for (int j=1+i; j<arr.Length; j++)
        {
            if (arr[i] == arr[j] && TestValue(arr[i], outArr) == false)
            {
                // увеличиваем размер выходного массива
                Array.Resize(ref outArr, index + 1);
                // помещаем в выходной массив найденное
                // значение и наращиваем индекс
                outArr[index] = arr[i];
                index++;
                break;
            }
        }
    }
    return outArr;
}

int[] res = SameValues(inputArray);
PrintResult("\nЗначения имеют один или более повторений в исходном массиве: ");
Print1DArrJoin(res);
// На сколько понял суть задачи и данные пояснения на уроке:
// со звёзд вывести все пары в массиве (имеют одинаковые значения 
// это как - 5, 5 ;  6, 6  , т. е. одинаковые числа)
