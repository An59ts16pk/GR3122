//========================================================================
// # Задача 27 Напишите программу, которая принимает на вход число и  
// выдаёт сумму цифр в числе.
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

// Вариант 1. Метод подсчёта суммы цифр числа по уроку
int SumDigit1(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }

    return sum;
}
// Вариант 2. Метод Math.DivRem и цикл while
int SumDigit2(int num)
{
    int sum = 0, rem;
    while (num != 0)
    {
        num = Math.DivRem(num, 10, out rem);
        sum += rem;
    }
    return sum;
}
// Вариант 3. Метод Math.DivRem и цикл for
int SumDigit3(int num)
{
    int sum = 0, rem;
    for (sum = 0; num != 0; sum += rem)
    {
        num = Math.DivRem(num, 10, out rem);
    }
    return sum;
}

int number = ReadData("\nВведите число: ");

DateTime d1 = DateTime.Now;
int res1 = SumDigit1(number);
Console.WriteLine("Вариант 1 = " + (DateTime.Now - d1));

DateTime d2 = DateTime.Now;
int res2 = SumDigit2(number);
Console.WriteLine("Вариант 2 = " + (DateTime.Now - d2));

DateTime d3 = DateTime.Now;
int res3 = SumDigit3(number);
Console.WriteLine("Вариант 3 = " + (DateTime.Now - d3));

PrintResult("\nВариант 1. Сумма цифр в числе = " + res1);
PrintResult("Вариант 2. Сумма цифр в числе = " + res2);
PrintResult("Вариант 3. Сумма цифр в числе = " + res3);

// Самый быстрый Вариант 3
