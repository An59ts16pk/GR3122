//=======================================================================
// # Задача 13 Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьеё цифры нет.
//=======================================================================
Console.WriteLine("\nВариант 1");
Console.Write("Введите  число = ");
string? userNumber = Console.ReadLine();

if (userNumber != null)
{
     if (userNumber.Length >= 3)
     {
         char[] arrayNumber = userNumber.ToCharArray();
         Console.WriteLine("Третья цифра числа = " + arrayNumber[2]);
     }
     else
     {
         Console.WriteLine("Третьей цифры нет");
     }
}

Console.WriteLine("\nВариант 2");
// Глобальные переменные
double userN = 0;         // число пользователя
double numLen = 0;        // разрядность числа 
bool flag = false;        // флаг, если разрядность >= 3
double thirdDigit = 0;    // результат

// Получаем число от пользователя
// и получаем разрядность числа
void ReadData()
{
    Console.Write("Введите число = ");
    string? inputNumber = Console.ReadLine();
    if (inputNumber != null)
    {
        if (inputNumber.Length >= 3)
        {
            numLen = inputNumber.Length;
            userN = int.Parse(inputNumber);
            flag = true;
        }
    }
}
// вычисляем третью цифру
void CalculateData()
{
    if (flag)
    {
        thirdDigit = (userN % Math.Pow(10, numLen - 2)) / Math.Pow(10, numLen - 3);
    }
}
// выводим результат
void PrintData()
{
    if (flag)
    {
        Console.WriteLine("Третья цифра числа = " + (int)thirdDigit);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет.");
    }
}

ReadData();
CalculateData();
PrintData();
