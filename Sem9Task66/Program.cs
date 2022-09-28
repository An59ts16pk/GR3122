//=========================================================
// # Задача 66 Задайте значение M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке
//  от M до N.
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

// Метод (рекурсивный) вычисления суммы от М до N.
int RecSumNums(int numM, int numN)
{
    if (numM == numN) return numN;
    if (numM < numN) return numM + RecSumNums(numM+1, numN);
    else return numN + RecSumNums(numN+1, numM);
}

int numberM = ReadData("Введите начальное число M: ");
int numberN = ReadData("Введите конечное число N: ");
int result = RecSumNums(numberM, numberN);
PrintResult($"Сумма чисел от {numberM} до {numberN} = {result}");
