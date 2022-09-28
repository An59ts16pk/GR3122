//=========================================================
// # Задача 67 Напишите программу, которая будет принимать
// число N и возвращать сумму его цифр.
//=========================================================
// // Чтение данных из консоли
// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// // Метод, принимает строку, выводит в консоль
// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

// int SumDigit(int num)
// {
//     if (num / 10 == 0)
//         return num;
//     return SumDigit(num / 10) + num % 10;
// }

// int number = ReadData("Введите число: ");
// int sum = SumDigit(number);
// PrintResult("Сумма цифр в числе: "+sum);

// Метод считывания данных пользователя.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод вывод результата.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// возвращает сумму числа
int RecSumDigit(int num)
{
    if (num == 0) return 0;
    return num % 10 + RecSumDigit(num / 10);
    // или через тернарный оператор
    // return num == 0 ? 0 : num % 10 + RecSumDigit(num / 10);
}

int number = ReadData("Введите начальное число: ");
int sum = RecSumDigit(number);
PrintResult("Сумма цифр числа: " + sum);
