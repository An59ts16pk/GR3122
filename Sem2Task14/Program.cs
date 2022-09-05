//========================================================================
// # Задача 14 Напишите программу, которая принимает на вход число  
// и проверяет, кратно ли оно одновременно 7 и 23. 
//========================================================================

// евгений
Console.WriteLine("\nВариант 1");

Console.Write("Введите число: ");
string? inputLineA = Console.ReadLine();
if (inputLineA != null)
{
    int inputNumberA = int.Parse(inputLineA);

    if(inputNumberA%7==0 && inputNumberA%23==0)
    {
        Console.Write("Число кратно одновременно 7 и 23");
    }
    else
    {
        Console.Write("Число не кратно одновременно 7 и 23");
    }
}

// михаил
Console.WriteLine("\nВариант 2");

int number, resultA, resultB;

// запрашивает число у пользователя
// (принимает текст запроса и команду выхода)
int RequestNumber(string text = "Enter number", string exitCmd = "q")
{
    // цикл выполняется до введения целого числа или команды выхода "q"
    while(true)
    {
        Console.Write(text + ": ");
        string? inputLine = Console.ReadLine();
        // игнорируем пробел
        if (inputLine == null)                        // если ни чего, то бесконечно крутит прогу
        {
            continue;
        }
        // выходим из программы надо написать
        if (inputLine.ToLower() == exitCmd)           // введён выход - выходит
        {
            Environment.Exit(0);
        }
        // выдаём полученное число
        if (int.TryParse(inputLine, out int number))  // введено число - возвращает это число
        {
            return number;
        }
    }
}
// чтение данных из консоли
void ReadData()
{
    number = RequestNumber("Enter number");
}
// определяем кратность чисел
void CalculateData()
{
    resultA = number % 7;
    resultB = number % 23;
}
// вывод данных
void PrintData()
{
    if (resultA == 0 && resultB == 0)
    {
        Console.WriteLine("Число кратно 7 и 23");
    }
    else
    {
        Console.WriteLine("Число не кратно 7 и 23");
    }
}
ReadData();
CalculateData();
PrintData();

// анатолий
Console.WriteLine("\nВариант 3");

string? inputLineAA = Console.ReadLine();
if (inputLineAA != null) Console.Write(((int.Parse(inputLineAA) % 7 == 0) && (int.Parse(inputLineAA) % 23 == 0)) ? ("Кратно") : ("Не кратно"));
