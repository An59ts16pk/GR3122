//=========================================================
// # Задача 65 Задайте значение M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от M до N. Выполнить с помощью рекурсии.
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

//
string RecNumsMN(int m, int n)
{
    if (m == n) return n.ToString();
    if (m < n) return m + ", " + RecNumsMN(m+1, n);
    else return n + ", " + RecNumsMN(n+1, m); 
}

int numberM = ReadData("Введите начальное число M: ");
int numberN = ReadData("Введите конечное число N: ");
string result = RecNumsMN(numberM, numberN);
PrintResult("Числа в промежутке от M до N: " + result);
