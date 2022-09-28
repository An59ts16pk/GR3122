//=========================================================
// # Задача 69 Напишите программу, которая на вход 
// принимает два числа A и B. Возведите число A в целую 
// степень числа B с помощью рекурсии.
//=========================================================
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Вывод в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// возвращает сумму цифр числа numN
int RecPow(int a, int b)
{
    // if(b==1) return a;
    // return a*RecPow(a,b-1);

    return b == 1 ? a : a * RecPow(a, b - 1);
}

int NoRecPow(int num, int pow)
{
    int result = 1;
    for (int i = 0; i < pow; i++)
    {
        result = result * num;
    }
    return result;
}

int MyPow(int number, int pow)
{
    if (pow == 2)
    {
        return number * number;
    }
    if (pow == 1)
    {
        return number;
    }

    if (pow % 2 == 0)
    {
        return MyPow(number, pow / 2) * MyPow(number, pow / 2);
    }
    else
    {
        return MyPow(number, pow / 2) * MyPow(number, pow / 2 + 1);
    }

}



int a = ReadData("Введите числа А: ");
int b = ReadData("Введите числа B: ");

int out1=0;
int out2=0;
int out3=0;
double out4=0;

DateTime d4 = DateTime.Now;
for (int i = 0; i < 10000000; i++)
{
    out4 = Math.Pow(a, b);
}
PrintResult("Решение Math.Pow " + (DateTime.Now - d4));

DateTime d3 = DateTime.Now;
for (int i = 0; i < 10000000; i++)
{
    out3 = MyPow(a, b);
}
PrintResult("Решение MyPow " + (DateTime.Now - d3));

DateTime d1 = DateTime.Now;
for (int i = 0; i < 10000000; i++)
{
    out1 = RecPow(a, b);
}
PrintResult("Решение рекурентное " + (DateTime.Now - d1));
DateTime d2 = DateTime.Now;
for (int i = 0; i < 10000000; i++)
{
    out2 = NoRecPow(a, b);
}
PrintResult("Решение простое " + (DateTime.Now - d2));
