//========================================================================
// # Задача 18 Напишите программу, которая по заданному номеру четверти,  
// показывает диапазон возможных координат точек в этой четверти (X и Y).
//========================================================================
// чтение данных из консоли
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}
// вычисляем
string QuterBorderAsk(int numQuter)
{
    if (numQuter == 1)
        return "x>0 y>0";
    if (numQuter == 2)
        return "x<0 y>0";
    if (numQuter == 3)
        return "x<0 y<0";
    if (numQuter == 4)
        return "x>0 y<0";

    return " ";       
}
// выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите номер четверти: ");

string res = QuterBorderAsk(num);

PrintResult(res);
