//=======================================================
// # Задача 64 Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.
//=======================================================
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

// Метод (рекурсивный) нахожденя чисел от N до 1.
string RecNaturalNums(int num)
{
    if (num == 1) return "1";
    return num + ", " + RecNaturalNums(num-1);
}

int number = ReadData("Введите число: ");
string result = RecNaturalNums(number);
PrintResult($"\nНатуральные числа от {number} до 1: \n{result}");
