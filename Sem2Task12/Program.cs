//========================================================================
// # Задача 12 Напишите программу, которая будет принимать на вход два  
// числа и выводить, является ли второе число кратным первому. Если второе
// число некратно первому, то программа выводит остаток от деления.
//========================================================================

//константин
void Variant1()
{
    Console.WriteLine("\nВариант 1");
    Console.Write("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();
    if (inputLineA != null && inputLineB != null)
    {
        int inputNumberA = int.Parse(inputLineA);
        int inputNumberB = int.Parse(inputLineB);
    
        Console.WriteLine((inputNumberB % inputNumberA == 0) ? ("Второе число кратно первому") : ("Остаток от деления: " + inputNumberB % inputNumberA));
    }
}

//евгений
 void Variant2()
{
    Console.WriteLine("\nВариант 2");
    Console.Write("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();

    if (inputLineA != null && inputLineB != null)
    {
        int inputNumberA = (int)int.Parse(inputLineA);
        int inputNumberB = (int)int.Parse(inputLineB);

        Console.WriteLine(inputNumberB % inputNumberA == 0 ? "Является кратным" : inputNumberB % inputNumberA);
    }
}

Variant1();
Variant2();

// Variant 3

// глобальные переменные
int inputNumberA = 0;
int inputNumberB = 0;
bool result = false;

ReadData();
ConculateData();
PrintData();

// Получаем два числа от пользователя
void ReadData()
{
    Console.WriteLine("\nВариант 3");
    Console.Write("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();
    if (inputLineA != null && inputLineB != null)
    {
        inputNumberA = int.Parse(inputLineA);
        inputNumberB = int.Parse(inputLineB);
    }
}

// Определяем кратность чисел
void ConculateData()
{
    result = (inputNumberB % inputNumberA == 0);
}

// Выводим данные вычисления
void PrintData()
{
    if (result)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("Остаток от деления: " + + inputNumberB % inputNumberA);
    }
}
