//========================================================================
// # Задача 20 Напишите программу, которая принимает на вход координаты  
// двух точек и находит расстояние между ними в 2D пространстве.
//========================================================================
// ввод данных
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}
// расстояние между двумя точками
double Calculate(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
}
// вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// соберём данные
int x1 = ReadData("Введите x1: ");
int y1 = ReadData("Введите y1: ");
int x2 = ReadData("Введите x2: ");
int y2 = ReadData("Введите y2: ");

// вывод результата
PrintResult(Math.Round(Calculate(x1,y1,x2,y2),2).ToString());

// // решение Константина
// int CalculateDistance(int x1, int y1, int x2, int y2);
// {
//     double distance =  Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
//     return distance;   
// }

// int x1 = ReadData("Введите координату X первой точки: ");
// int y1 = ReadData("Введите координату Y первой точки: ");
// int x2 = ReadData("Введите координату X второй точки: ");
// int y2 = ReadData("Введите координату Y второй точки: ");

// double result = CalculateDistance(x1, y1, x2, y2);
// PrintResult("Расстояние между точками: " + Math.Round(result, 2));
