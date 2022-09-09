//========================================================================
// # Задача 19 Напишите программу, которая принимает на вход пятизначное  
// число и проверяет, является ли оно палиндромом.
//========================================================================
// решение с урока Вариант 1
Console.WriteLine("\nVariant 1 - пятизначное число.");
// вводим число из консоли
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}
// определяем - число палиндром или нет
string TestPalindrome(int num)
{
    if ((num / 10000 == num % 10) && ((num / 1000) % 10 == (num % 100) / 10))
    {
        return "Палиндром";
    }
    else
    {
        return "Не палиндром";
    }
}
// выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int number = ReadData("Введите пятизначное число: ");
PrintResult(TestPalindrome(number));
//========================================================
// решение для числа любой длины Вариант 2
Console.WriteLine("\nVariant 2 - число любой длины.");
// метод ввода числа ввиде строки и возвращаем строку
string ReadDataStr(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    string number = (Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}
// тест на палиндром - передаём строку и возвращаем
// результат проверки строкой
string Palindrome(string number)
{
    // преобразуем строку числа в два массива символов
    char[] numberParent = number.ToString().ToCharArray();
    char[] numberRevers = number.ToString().ToCharArray();
    // один массив разворачиваем
    Array.Reverse(numberRevers);
    // оба массива преобразуем обратно в строки
    string strParent = new string(numberParent);
    string strRevers = new string(numberRevers);
    if (strParent == strRevers)        //сравниваем два массива
    {
        return "\nЧисло " + number + " палиндром.";
    }
    else
    {
        return "\nЧисло " + number + " не палиндром.";
    }
}
// вводим число
string num = ReadDataStr("Введите число :");
// метод вывода из Вариант 1
PrintResult(Palindrome(num));
//==========================================================
// решение для пятизначного числа через словарь Вариант 3
Console.WriteLine("\nVariant 3 - решение через словарь.");
var numDict = new Dictionary<int, int>() {};         //создаём пустой словарь
bool flag = false;                                   //флаг проверки числа на пять разрядов
// метод заполняет словарь значениями
void valuesDict()
{
    int i = 10;
    while (i < 100)
    {
        numDict[i] = ((i % 10) * 10) + (i / 10);
        ++i;
    }
}
// метод проверяет число на палиндром по словарю
string PalindromeDict(int numD)
{
    string numS = numD.ToString();         //число в строку для проверки пятизначности
    int keyD = numD / 1000;                //два старших разряда - ключ словаря 
    if (numS.Length == 5)
    {
        flag = true;
        //проверяем на палиндром по ключу словаря и его значению
        if (numDict.ContainsKey(keyD) && numDict[keyD] == numD % 100)
        {
            return "\nЧисло " + numD + " - палиндром.";
        }
        else
        {
            return "\nЧисло "+ numD + " - не палиндром.";
        }
    }
    return "";
}
valuesDict();                                         //заполняем словарь значениями
// метод ввода из Вариант 1
int numberD = ReadData("Введите пятизначное число");
// тест на палиндром
string result = PalindromeDict(numberD);
// метод вывода из Вариант 1
PrintResult(flag ? result : "\nЧисло не пятизначное.");
