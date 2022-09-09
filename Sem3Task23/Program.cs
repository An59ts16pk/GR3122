//========================================================================
// # Задача 23 Напишите программу, которая принимает на вход число (N) и  
// выдаёт таблицу кубов чисел от 1 до N.
//========================================================================
// Вариант 1 решение по уроку
Console.WriteLine("\nVariant 1.");
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
// выводит числа от 1 до N и передаём аргументом pow
// степень выводимого числа
string LineNumbers(int numberN, int pow)
{
    int i = 1;
    string outLine = string.Empty;    // пустая строка
    while(i < numberN)
    {
        outLine = outLine + Math.Pow(i, pow) + "\t";
        ++i;
    }
    // вывод последнего числа чтобы не печатался 
    // последний разделитель
    outLine = outLine + Math.Pow(numberN, pow);      
    return outLine;
}
// выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число N:");

PrintResult(LineNumbers(num, 1));
PrintResult(LineNumbers(num, 3));
//==========================================================
// Вариант 2 решение с учётом пробелов
Console.WriteLine("\nVariant 2.");
// методы создания таблицы кубов чисел
string TableNumbers(int numN)
{
    int i = 1;
    // две строки вывода результата
    string outLine1 = string.Empty;
    string outLine2 = string.Empty;
    while(i < numN)
    {
        // две строки промежуточных результатов
        string res1 = "" + i;
        string res2  = "" + Math.Pow(i, 3);
        // определяем разницу длин строк промежуточных результатов
        int lenRes = res2.Length - res1.Length;
        // добавляем промежуточным строкам нужное количество пробелов
        res1 = res1 + " ".PadRight(lenRes+1);
        res2 = res2 + " ".PadRight(1);
        // прибавляем промежуточный результат к выходным строкам
        outLine1 = outLine1 + res1;
        outLine2 = outLine2 + res2;
        ++i;
    }
    // вывод последних чисел, чтоб не печатались последние пробелы
    outLine1 = outLine1 + numN;
    outLine2 = outLine2 + Math.Pow(numN, 3);
    
    return outLine1 + "\n" + outLine2;
}
// методы ввода и вывода из Вариант 1
int number = ReadData("Введите число N:");
PrintResult(TableNumbers(number));
