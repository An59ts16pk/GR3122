//========================================================================
// # Задача 22 Напишите программу, которая принимает на вход число (N) и  
// выдаёт таблицу квадратов чисел от 1 до N.
//========================================================================
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
// выводит числа от 1 до N
string LineNumbers(int numberN, int pow)
{
    int i = 1;
    string outLine = string.Empty;    // пустая строка
    while(i < numberN)
    {
        outLine = outLine + Math.Pow(i, pow) + "\t";
        ++i;
    }
    outLine = outLine + Math.Pow(numberN, pow);      // чтобы не печатался последний разделитель
    return outLine;
}
// выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число N:");

PrintResult(LineNumbers(num, 1));
PrintResult(LineNumbers(num, 2));
