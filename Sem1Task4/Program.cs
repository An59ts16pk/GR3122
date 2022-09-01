//==================================================================================
// # 4 Напишите программу, которая на вход принимает три числа и выдаёт,
// максимальное из этих чисел.
//==================================================================================

Console.Write("Введите первое число A = ");
string? inputLineA = Console.ReadLine();
Console.Write("Введите второе число B = ");
string? inputLineB = Console.ReadLine();
Console.Write("Введите третье число C = ");
string? inputLineC = Console.ReadLine();                             //вводим три числа
if (inputLineA != null && inputLineB != null && inputLineC != null)  //проверяем три числа на null
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);                        //парсим три числа в вещественные и преобразуем в int

    // Вариант 1
    Console.WriteLine("\nВариант 1.");
    if (inputNumberA > inputNumberB)                                //сравниваем первое со вторым
    {
        if (inputNumberA > inputNumberC)                            //сравниваем первое с третьим
        {
            Console.Write("\nМаксимальное первое число A = ");
            Console.WriteLine(inputNumberA);                        //если Да, выводим в консоль первое число
        }
        else                                                        //иначе                                                     
        {
            Console.Write("\nМаксимальное третье число C = ");
            Console.WriteLine(inputNumberC);                        //выводим в консоль третье число
        }
    }
    else                                                            //иначе
    {
        if (inputNumberB > inputNumberC)                            //сравниваем второе с третьм
        {
            Console.Write("\nМаксимальное второе число B = ");
            Console.WriteLine(inputNumberB);                        //если Да, выводим в консоль второе число
        }
        else                                                        //иначе
        {
            Console.Write("\nМаксимальное третье число C = ");
            Console.WriteLine(inputNumberC);                        //выводим в консоль третье число 
        }
    }
    // вариант 2
    Console.WriteLine("\nВариант 2.");
    int max = inputNumberA;                              //предполагаем, что макимальное первое число   
    string maxString = "первое, A = ";                   //вспомогательная переменная о максимальном числе
    if (inputNumberB > max)                              //сравниваем второе число с максимальным
    {
        max = inputNumberB;                              //если Да, то максимальное теперь второе число
        maxString = "второе, B = ";                      //и изменяем вспомогательную переменную
    }
    if (inputNumberC > max)                              //сравнмваем третье число с максимальным
    {
        max = inputNumberC;                              //если Да, то максимальное теперь третье число
        maxString = "третье, C = ";                      //и изменяем вспомогательную переменную
    }
    Console.Write("\nМаксимальное " + maxString);
    Console.WriteLine(max);                              //выводим в консоль максимальное
}
