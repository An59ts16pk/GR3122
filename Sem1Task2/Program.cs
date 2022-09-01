//==================================================================================
// # 2 Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число больше, а какое меньше.
//==================================================================================
// Вариант 1
string? inputLineA = Console.ReadLine();                                //вводим в консоле первое чмсло
string? inputLineB = Console.ReadLine();                                //вводим в консоле второе число
if (inputLineA != null && inputLineB != null)                           //проверяем оба числа на null
{
    int inputNumberA = int.Parse(inputLineA);                           //первое строковое парсим в вещественное число и в int
    int inputNumberB = int.Parse(inputLineB);                           //второе строковое парсим в вещественное число и в int

    Console.WriteLine("\nВариант 1.");
    if (inputNumberA == inputNumberB)                                   //сравниваем числа на равенство
    {
        Console.WriteLine("Числа равны");                               //выводим сообщение,если равны 
    }
    else                                                                //иначе
    {
        if (inputNumberA > inputNumberB)                                //оператор ветвления и сравниваем два числа
        {
            Console.Write("Первое число больше второго, число = ");
            Console.WriteLine(inputNumberA);                            //если Да, выводим первое число
            Console.Write("    Второе число меньше первого, число = ");
            Console.WriteLine(inputNumberB);                            //выводим меньшее число
        }
        else                                                            //иначе
        {
            Console.Write("Второе число больше первого, число = ");
            Console.WriteLine(inputNumberB);                            //выводим второе чичло
            Console.Write("    Первое число меньше второго, число = ");
            Console.WriteLine(inputNumberA);                            //выводим меньшее число
        }
    }

    // Вариант 2
    Console.WriteLine("\nВариант 2.");
    int result = inputNumberA - inputNumberB;                           //вычитаем второе число из первого
    if (result == 0)                                                    //проверяем результат на равенство 0
    {
        Console.WriteLine("Числа равны");                               //выводим сообщение. если равны
    }
    else
    {
        if (result > 0)                                                 //если результат больше 0
        {
            Console.Write("Первое число больше второго, число = ");
            Console.WriteLine(inputNumberA);                             //если Да, выводим первое число
            Console.Write("    Второе число меньше первого, число = ");
            Console.WriteLine(inputNumberB);                             //выводим меньшее число
        }
        else                                                             //иначе
        {
            Console.Write("Второе число больше первого, число = ");
            Console.WriteLine(inputNumberB);                             //выводим второе число
            Console.Write("    Первое число меньше второго, число = ");
            Console.WriteLine(inputNumberA);                             //выводим меньшее число
        }
    }
}
