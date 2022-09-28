//=======================================================
// # Задача 63 Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от 1 до N. Выполнить с помощью рекурсии.
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

//   №  outLine
//1  4  4 3 2 1 "" 
//2  3  3 2 1 ""
//3  2  2 1 ""
//4  1  1 ""
//5  0

// Метод выводит числа от N до 1.
string LineGenRec(int numN)
{
    // точка остановки
    if (numN == 0) return "";
    string outLine = numN + " " + LineGenRec(numN-1);
    return outLine;
}

// Метод выводит числа от 1 до N.
string RecGenLine(int numN)
{
    // точка остановки
    if (numN == 0) return "";
    // меняем сборку строки 
    // (по стэку будет дописываться спереди, а не сзади)
    string outLine = RecGenLine(numN-1) + " " + numN;
    return outLine;
}

int numN = ReadData("Введите число N: ");
string resultLine1 = LineGenRec(numN);
PrintResult($"\nНатуральные числа от {numN} до 1: \n{resultLine1}");

string resultLine2 = RecGenLine(numN);
PrintResult($"\nНатуральные числа от 1 до {numN}: \n{resultLine2}");
