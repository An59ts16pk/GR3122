//========================================================================
// # Задача 29 Напишите программу, которая задаёт массив из 8 элементов и  
// выводит их на экран. Ввести с клавиатуры длину массива и диапазон
// значений элементов.
//========================================================================
// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}
// Метод получения массива заданной длины и с 
// выбором диапазона заполняемых значений
int[] GenArray(int arrLen, int start, int stop)
{
    // инициализируем массив
    int[] outArray = new int[arrLen];
    // инициализируем рэндом
    Random rnd = new Random();
    // заполняем массив случайными элементами
    // из заданного диапазона
    for (int i = 0; i < arrLen; i++)
    {
        outArray[i] = rnd.Next(start, stop);
    }
    return outArray;
}
// Метод вывода массива в терминал
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

int numArr = ReadData("\nВведите длину массива: ");
Console.WriteLine("Задайте границы диапазона значений элементов:");
int numStart = ReadData("Введите начальную границу: ");
int numStop = ReadData("Введите конечную границу: ");

PrintArray(GenArray(numArr, numStart, numStop));

//===================================================================
// Дополнительно. Написать программу, которая из имён через запятую
// выберет случайное имя и выведет в терминал.
//===================================================================
// Метод считывания данных пользователя
string ReadDataString(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем строку
    string dataString = Console.ReadLine() ?? "0";
    // Возвращаем значение
    return dataString;
}
// Метод случайного выбора имени из строки
string ChoiceName(string namesSt)
{
    // инициализируем массив и заполняем именами из строки 
    string[] namesArray = namesSt.Split(", ");
    // инициализируем рэндом
    Random rnd = new Random();
    // выбираем случайно индекс из диапазона длины массива
    int indexName = rnd.Next(0, namesArray.Length);
    // возвращаем случайно выбранное имя
    return namesArray[indexName];
}
// Метод вывода в терминал
void PrintResult(string line)
{
    Console.Write(line);
}

string namesString = ReadDataString("\nВведите имена через запятую: ");
PrintResult("Случайно выбранное имя из строки: " + ChoiceName(namesString));
