//========================================================================
// # Задача 21 Напишите программу, которая принимает на вход координаты  
// двух точек и находит расстояние между ними в 3D пространстве.
//========================================================================
// решение по уроку Вариант 1
Console.WriteLine("\nVariant 1");
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
double Calculate(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(
        (x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));
}
// вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// соберём данные
int x1 = ReadData("Введите x1: ");
int y1 = ReadData("Введите y1: ");
int z1 = ReadData("Введите z1: ");
int x2 = ReadData("Введите x2: ");
int y2 = ReadData("Введите y2: ");
int z2 = ReadData("Введите z2: ");

// вывод результата
PrintResult("Результат = " + Math.Round(Calculate(x1,y1,z1,x2,y2,z2),2).ToString());
//==================================================================
// решение для введения координат
// одной строкой Вариант 2
Console.WriteLine("\nVariant 2");
// метод ввода двух координат ввиде строки и возвращаем строку
string ReadDataStr(string line)
{
    //Выводим сообщение
    Console.WriteLine(line + " (пример: A(x1,y1,z1);B(x2,y2,z2)): ");
    //Считываем строку
    string number = (Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}
// метод вычисляет расстояние между двумя точками
// получает одну строку - выводит значение double
double CalculateDistance(string coord)
{
    // в строке удаляем буквы и ненужные спецсимволы
    coord = string.Join("", coord.Split('A', 'B' ,'a' ,'b', '(', ')'));
    // получаем массив двух строк - координаты точек 
    string[] coordTo = coord.Split(";");
    // создаём два массива координат точек и
    // одновременно парсим каждую координату
    int[] crd1 = Array.ConvertAll(coordTo[0].Split(","), int.Parse);
    int[] crd2 = Array.ConvertAll(coordTo[1].Split(","), int.Parse);
    // вычисляем расстояние между точками и возвращаем результат
    return Math.Sqrt(
        (crd2[0]-crd1[0])*(crd2[0]-crd1[0]) + (crd2[1]-crd1[1])*(crd2[1]-crd1[1]) + (crd2[2]-crd1[2])*(crd2[2]-crd1[2])
    );
}

// введите координаты
string coordinates = ReadDataStr("Введите координаты двух точек");
// метод вывода объявлен в Вариант 1
// выводим результат
PrintResult("Результат = " + Math.Round(CalculateDistance(coordinates), 2).ToString());
