//========================================================================
// # Задача 24 Напишите программу, которая принимает на вход число (A) и  
// выдаёт сумму чисел от 1 до A.
//========================================================================
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

// метод вывода результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}


int VariantSumSimple(int numA)
{
    int sumOfNumbers = 0;
    for (int i=1; i<=numA; i++)
    {
        sumOfNumbers += i;
    }
    return sumOfNumbers;
}

int VariantSumGause(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1 + numA) * numA) / 2;
    return sumOfNumbers;
}

int numberA = ReadData("Введите число A: ");

DateTime d1 = DateTime.Now;
int res1 = VariantSumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = VariantSumGause(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до A равна (простой метод): " + res1);
PrintResult("Сумма чисел от 1 до A равна (метод Гаусса): " + res2);
