//======================================================================
// # Задача 11 Напишите программу, которая выводит случайное трёхзначное 
// число и удаляет вторую цифру этого числа.
//======================================================================
Console.WriteLine("\nВариант 1");
System.Random numberGenerator = new System.Random();
int number = numberGenerator.Next(100, 1000);
Console.WriteLine("\nСгенерированное случайное число = " + number);

int firstDigit = number / 100;
int thirdDigit = number % 10;

Console.WriteLine(firstDigit * 10 + thirdDigit);

void Variant2()
{
    Console.WriteLine("\nВариант 2");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);
    Console.WriteLine("\nСгенерированное случайное число = " + number);
    char[] charArray = number.ToString().ToCharArray();
    Console.Write(charArray[0]);
    Console.WriteLine(charArray[2]);
}

void Variant3()
{
    Console.WriteLine("\nВариант 3");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);
    Console.WriteLine("\nСгенерированное случайное число = " + number);
    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine("" + charArray[0] + charArray[2]);
}

Variant2();
Variant3();
