//========================================================================
// # Задача 26 Напишите программу, которая принимает на вход число и  
// выдаёт количество цифр в числе.
//========================================================================
// запрос данных у пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.Write(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

// метод вывода результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int DigitCount(int num)
{
    int count = 0;
    while(num > 0)
    {
        count += 1;
        num = num / 10;
    }

    return count;
}

// Вариант с длиной строки
int CalculateDigitsString(int num)
{
    string numString = num.ToString();
    return numString.Length;
}

// Вариант с логарифмом
int CalculateDigitsLog(int num)
{
    return (int)(Math.Log10(num) + 1);
}

int number = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
int res1 = DigitCount(number);
PrintResult("Количество цифр в числе = " + res1);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = CalculateDigitsString(number);
PrintResult("Количество цифр в числе = " + res2);
Console.WriteLine(DateTime.Now - d2);

DateTime d3 = DateTime.Now;
int res3 = CalculateDigitsLog(number);
PrintResult("Количество цифр в числе = " + res3);
Console.WriteLine(DateTime.Now - d3);
