//========================================================================
// # Задача 25 Напишите программу, которая принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
//========================================================================
// Задачи по уроку
Console.WriteLine("\nTasks lesson.");

// запрос данных у пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.Write(line);
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

// Метод возведения числа в степень
long Pow1(int A, int B)
{
    long res = 1;
    for (int i = 0; i < B; i++)
    {
        res = res * A;
    }
    return res;
}

// Метод возведения числа в степень через Math
double Pow2(double A, double B)
{
    return Math.Pow(A, B);
}

int numA1 = ReadData("Введите число A: ");
int numB1 = ReadData("Введите степень, число B: ");

DateTime d1 = DateTime.Now;
PrintResult("Число A в натуральной степени числа B: " + Pow1(numA1, numB1));
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
PrintResult("A в степени B через Math: " + Pow2(numA1, numB1));
Console.WriteLine(DateTime.Now - d2);
// Через Math быстрее примерно в 8 раз
//==========================================================================
// Калькулятор с пятью операциями +, -, *, /, ^
Console.WriteLine("\nКалькулятор с пятью операциями.");
// Метод ввода чисел из задачи выше

// Ввод арифметичекой операции.
char ReadOperator(string line)
{
    Console.Write(line + " (+, -, *, /, ^): ");
    string operString = Console.ReadLine() ?? "0";
    // берём из строки первый символ, если будет введено
    // больше символов
    char oper = operString[0];
    return oper;
}

// Методы арифметических операций:
string addNum(double A, double B)
{
    return (A + B).ToString();
}
string subNum(double A, double B)
{
    return (A - B).ToString();
}
string multNum(double A, double B)
{
    return (A * B).ToString();
}
string divNum(double A, double B)
{
    if (B != 0)
    {
        return (A / B).ToString();
    }
    else
    {
        return "Делить на ноль нельзя!";
    }
}
string expoNum(double A, double B)
{
    return (Math.Pow(A, B)).ToString();
}

// Метод - калькулятор.
string Calculator(double A, double B, char mOper)
{
    switch (mOper)
    {
        case '+': Console.WriteLine("\nСложение чисел = " + addNum(A, B)); break;
        case '-': Console.WriteLine("\nВычитание чисел = " + subNum(A, B)); break;
        case '*': Console.WriteLine("\nУмножение чисел = " + multNum(A,B)); break;
        case '/': Console.WriteLine("\nДеление чисел = " + divNum(A,B)); break;
        case '^': Console.WriteLine("\nВозведение числа А в степень В = " + expoNum(A, B)); break;
        default: Console.WriteLine("\nТакой операции нет!"); break;
    }
    return "";
}

double numA2 = ReadData("\nВведите число A:          ");
char mathOper = ReadOperator("оператор");
double numB2 = ReadData("Введите число B:          ");

DateTime d3 = DateTime.Now;
Calculator(numA2, numB2, mathOper);
Console.WriteLine(DateTime.Now - d3);
