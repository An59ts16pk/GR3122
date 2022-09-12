// Задача - проверка числа на палиндром
//===============================================================
// // решение Лилии
// // запрос данных у пользователя
// int ReadDataL(string line)
// {
//     //Выводим сообщение
//     Console.WriteLine(line);
//     //Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     //Возвращаем значение
//     return number;
// }

// // тест на пятизначность и палиндром
// bool TestPolin(int numberP)
// {
//     if ((numberP > 9999) && (numberP < 100000))
//     {
//         if ((numberP / 10000) == (numberP % 10) && (numberP / 1000) % 10 == (numberP /10) % 10)
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }
//     else
//     {
//         Console.WriteLine("Try again!");
//         return false;
//     }
// }

// // вывод результата
// void PrintData(int numberP)
// {
//     if (TestPolin(numberP))
//     {
//         Console.WriteLine("Tsis's Polindrom. Well done!");
//     }
//     else
//     {
//         Console.WriteLine("Tsis isn't Polindrom. Sory!");
//     }
// }

// // собираем данные
// int numberP = ReadDataL("input five-digit number Polindrom: ");
// PrintData(numberP);

// //============================================================
// // решение Кирилла
// // Решение для любого числа
// // метод считывания данных
// double ReadDataK(string line)
// {
//     Console.WriteLine(line);
//     double number = double.Parse(Console.ReadLine() ?? "0");
// }
// Console.WriteLine("Hello, World!");

// // метод проверки палиндрома
// bool PalindromeTest(double a)
// {
//     char[] charArray = a.ToString().ToCharArray();
//     Array.Reverse(charArray);  // тут просто разворачиваем массив
//     double reversedArray = double.Parse(charArray);  // обратно в число
//     if(reversedArray == a)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// // метод вывода результата
// void PrintResult(bool res)
// {
//     if(res)
//     {
//         Console.WriteLine("Введённое число является палиндромом.");
//     }
//     else
//     {
//         Console.WriteLine("Введённое число не является палиндромом.");
//     }
// }

// double inputNumber = ReadDataK("Введите число: ");
// bool res = PalindromeTest(inputNumber);
// PrintResult(res);
//========================================================
// измерение скорости работы этих двух алгоритмов решений
// запрос данных у пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

// метод со словарём
Dictionary<int, int> GenerateDicPoli()
{
    Dictionary<int, int> palidrom = new Dictionary<int, int>();
    for(int i = 10; i < 100; i++)
    {
        int polik = i*100 + (i%10)*10 + i/10;
        palidrom.Add(polik, 0);
        Console.WriteLine(polik);
    }
    return palidrom;
}

bool TestPolinHash(int numberP, Dictionary<int, int> dict)
{
    if (dict.ContainsKey(numberP))
    {
        return true;
    }
    else
    {
        return false;
    }
}

// тест на пятизначность и палиндром Лилия
bool TestPolin(int numberP)
{
    if ((numberP / 1000) == (numberP % 100))
    {
        return true;
    }
    else
    {
        return false;
    }
}

// метод проверки палиндрома Кирилл
bool PalindromeTest(double a)
{
    char[] charArray = a.ToString().ToCharArray();
    Array.Reverse(charArray);  // тут просто разворачиваем массив
    double reversedArray = double.Parse(charArray);  // обратно в число
    if(reversedArray == a)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int polindrom = ReadData("Введите полиндром: ");

Dictionary<int, int> palidromDic = GenerateDicPoli();

DateTime d1 = DateTime.Now;
TestPolin(polindrom);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
PalindromeTest(polindrom);
Console.WriteLine(DateTime.Now - d2);

DateTime d3 = DateTime.Now;
TestPolinHash(polindrom, palidromDic);
Console.WriteLine(DateTime.Now - d3);
