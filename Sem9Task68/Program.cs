//=========================================================
// # Задача 68 Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных
// числа m и n.
//=========================================================
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

// Рекурсивный метод вычисления функции Аккермана.
int RecAckerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m != 0) && (n == 0))
      return RecAckerman(m - 1, 1);
    else
      return RecAckerman(m - 1, RecAckerman(m, n - 1));
}

int numberM = ReadData("\nВведите начальное число m: ");
int numberN = ReadData("Введите конечное число n: ");
long result = RecAckerman(numberM, numberN);
PrintResult($"\nЗначение функции Аккермана, если m = {numberM}, n = {numberN}: {result}");
