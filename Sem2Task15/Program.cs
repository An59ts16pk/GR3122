//=======================================================================
// # Задача 15 Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
//=======================================================================
Console.WriteLine("\nВариант 1");
Console.Write("Введите  число = ");
string? userNumber = Console.ReadLine();

if (userNumber != null)
{
    int userNum = int.Parse(userNumber);
    if (userNum >= 1 && userNum <= 7)
    {
        Console.WriteLine((userNum == 6 || userNum == 7) ? "Это выходной день!" : "Будний день.");
    }
    else
    {
        Console.WriteLine("Такого дня недели нет.");
    }
}

// использование словаря
Console.WriteLine("\nВариант 2");
var dayWeek = new Dictionary<int, string>()
{
    {1, "Понедельник будний"},
    {2, "Вторник будний"},
    {3, "Среда будний"},
    {4, "Четверг будний"},
    {5, "Пятница будний"},
    {6, "Суббота выходной"},
    {7, "Воскресенье выходной"}
};
// Глобальные переменные
int inputNum = 0;
string result = "";
// Метод ввода числа пользователя
void ReadData()
{
    Console.Write("Введите число дня недели = ");
    string? inputNumber = Console.ReadLine();
    if (inputNumber != null)
    {
        inputNum = int.Parse(inputNumber);
    }
}
// Метод вычисления дня недели по словарю
void CalculateData()
{
    result = (inputNum >= 1 && inputNum <= 7) ? dayWeek[inputNum] : "Такого дня недели нет.";
}
// Вывод результата
void PrintDate()
{
    Console.WriteLine("день недели - " + result);
}
ReadData();
CalculateData();
PrintDate();
