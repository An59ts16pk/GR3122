//====================================================================
// # Задача 42 Напишите программу, котгорая будет преобразовывать 
// десятичное число в двоичное.
//====================================================================
// // Метод считывания данных пользователя
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

// // Метод, принимает строку, выводит в консоль
// void PrintResult(string prefix, string data)
// {
//     Console.WriteLine(prefix + data);
// }

// string DecToBin(int number)
// {
//     string binNumber = "";

//     while (number > 0)
//     {
//         binNumber = number % 2 + binNumber;
//         number = number / 2;
//     }

//     return binNumber;
// }

// int inputNumber = ReadData("Введите число: ");

// PrintResult("Исходное число в бинарном формате:", DecToBin(inputNumber));
// // PrintResult($"Число {inputNumber} в двоичном представлении: {DecToBin(inputNumber)}");

// //Метод считывания данных пользователя
// string ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     return Console.ReadLine() ?? "0";
// }
// string numb = ReadData("Введите число: ");
// string numbBin = Convert.ToString(Convert.ToInt32(numb, 10), 2);

// Console.Write($"Число {numb} в двоичной системе: {numbBin}");


// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

int numb = ReadData("Введите число: ");

string numbBin = Convert.ToString(numb, 2);
Console.WriteLine($"  Число {numb} в двоичной системе: {numbBin}");

numbBin = Convert.ToString(numb, 8);
Console.WriteLine($"  Число {numb} в восьмеричная системе: {numbBin}");

numbBin = Convert.ToString(numb, 16);
Console.WriteLine($"  Число {numb} в шестнадцатеричная системе: {numbBin}");
