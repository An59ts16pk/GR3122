//========================================================================
// # Задача 28 Напишите программу, которая принимает на вход число N и  
// выдаёт произведение чисел от 1 до N.
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

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Вариант преподавателя
long MultA(int numA)
{
    long mult = 1;
    int i = 1;
    while(i <= numA)
    {
        mult = mult * i;
        i++;
    }
    return mult;
}

// Вариант с циклом for (факториал)
long CalculateFactorial(int num)
{
    long factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}

// Вариант через рекурсию
long CalcData(int num)
{
    if (num == 1)
        return 1;
    return num * CalcData(num - 1);
}

int number = ReadData("Введите число: ");

long multNum = MultA(number);
PrintResult("Произведение чисел от 1 до A = " + multNum);

long factorial = CalculateFactorial(number);
PrintResult("Факториал равен: " + factorial);

long mNum = CalcData(number);
PrintResult("Произведение чисел через рекурсию = " + mNum);
