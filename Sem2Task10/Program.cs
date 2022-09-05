//=======================================================================
// # Задача 10 Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
//=======================================================================
// // Вариант 1
// Console.WriteLine("\nВариант 1");
// Console.Write("Введите трёхзначное число = ");
// string? userNum = Console.ReadLine();

// if (userNum != null)
// {
//     if (userNum.Length == 3)
//     {
//         char[] arrayNum = userNum.ToCharArray();
//         Console.WriteLine("Вторая цифра числа = " + arrayNum[1]);
//     }
//     else
//     {
//         Console.WriteLine("Число не трёхзначное");
//     }
// }
// // Вариает 2
// Console.WriteLine("\nВариант 2");
// int userN = int.Parse(userNum);
// if (userN > 99 && userN < 1000)
// {
//     Console.WriteLine("Вторая цифра числа = " + ((userN % 100) / 10));
// }
// else
// {
//     Console.WriteLine("Число не трёхзначное");
// }

// Глобальные переменные
int userN = 0;
string userNum = "";
bool flag = false;
// Получаем число от пользователя
// и проверяем на трёхзначность
void ReadData()
{
    Console.Write("Введите трёхзначное число = ");
    string? inputNumber = Console.ReadLine();
    if (inputNumber != null)
    {
        if (inputNumber.Length == 3)
        {
            userNum = inputNumber;
            userN = int.Parse(inputNumber);
            flag = true;
        }
        else
        {
            Console.WriteLine("\nЧисло не трёхзначное");
        }

    }
}
// Находим вторую цифру из массива символов (Char)
// и выводим результат
void Variant1()
{
    if(flag)
    {
        Console.WriteLine("\nВариант 1");
        char[] arrayNum = userNum.ToCharArray();
        Console.WriteLine("Вторая цифра числа = " + arrayNum[1]);
    }
}
// Находим вторую цифру из целочисленного
// и выводим результат
void Variant2()
{
    if (flag)
    {
        Console.WriteLine("\nВариант 2");
        Console.WriteLine("Вторая цифра числа = " + ((userN % 100) / 10));
    }
}
// объявляем методы
ReadData();
Variant1();
Variant2();
