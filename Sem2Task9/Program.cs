//======================================================================
// # Задача 9 Напишите программу, которая выводит случайные числа из 
// отрезка [10, 100] и показывает наибольшую цифру этого числа.
//======================================================================

void MyVariant1()
{
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine("\nСгенерированное случайное число = " + number);

    int firstDigit = number/10;
    Console.WriteLine("\nfirstDigit = " + firstDigit);
    int secondDigit = number%10;
    Console.WriteLine("secondDigit = " + secondDigit);

    Console.WriteLine("\nВариант 1 (оператор if - else)");
    if (firstDigit > secondDigit)
    {
        Console.WriteLine("\nНаибольшая цифра firstDigit = " + firstDigit);
    }
    else
    {
        Console.WriteLine("\nНаибольшая цифра secondDigit = " + secondDigit);
    }
}

void TernaryVariant2()
{
    Console.WriteLine("\nВариант 2 (тернарный оператор)");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine("\nСгенерированное случайное число = " + number);

    int firstDigit = number/10;
    Console.WriteLine("\nfirstDigit = " + firstDigit);
    int secondDigit = number%10;
    Console.WriteLine("secondDigit = " + secondDigit);
    
    Console.Write("\nНаибольшая цифра = ");
    Console.WriteLine((firstDigit > secondDigit) ? firstDigit : secondDigit);
}

void TernaryVariant3()
{
    Console.WriteLine("\nВариант 3 (тернарный оператор с выводом первая или вторая цифра)");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine("\nСгенерированное случайное число = " + number);

    int firstDigit = number/10;
    Console.WriteLine("\nfirstDigit = " + firstDigit);
    int secondDigit = number%10;
    Console.WriteLine("secondDigit = " + secondDigit);
    
    Console.WriteLine((firstDigit > secondDigit) ? "\nНаибольшая firstDigit = " + firstDigit : "\nНаибольшая secondDigit = " + secondDigit);
}

void CharVariant4()
{
    Console.WriteLine("\nВариант 4 (через char)");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine("\nСгенерированное случайное число = " + number);
    
    char[] charArray = number.ToString().ToCharArray();
    Console.Write("\nНаибольшее = ");
    Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);
}

MyVariant1();
TernaryVariant2();
TernaryVariant3();
CharVariant4();
