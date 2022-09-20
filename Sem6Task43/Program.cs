//====================================================================
// # Задача 43 Напишите программу, которая найдёт точку пересечения  
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//====================================================================
// Решение задачи по уроку.
// Метод считывания данных пользователя.
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Метод решения системы уравнений для нахождения
// координат точки пересечения двух прямых.
// y = k1 * x + b1, y = k2 * x + b2
string PointFindString(double k1, double b1, double k2, double b2)
{
    string res = String.Empty;
    if (k1 == k2 && b1 == b2) return "Бесконечное количество решений!";
    else if (k1 == k2) return "Прямые параллельны - пересечений нет!";
    double x = Math.Round(((-b1 + b2) / (k1 - k2)), 2);
    double y = Math.Round((k2 * x + b2), 2);
    res = ($"Прямые пересекаются в точке координат: x = {x}; y = {y}");

    return res;
}

PrintResult("\n  Задача по уроку.");
PrintResult("\nЗадайте коэффициенты первой прямой: ");
int k1 = ReadData("Введите k1: ");
int b1 = ReadData("Введите b1: ");
PrintResult("Задайте коэффициенты второй прямой: ");
int k2 = ReadData("Введите k2: ");
int b2 = ReadData("Введите b2: ");

PrintResult(PointFindString(k1, b1, k2, b2));

//========================================================
// * Задача. Найдите площадь треугольника образованного 
// пересечением трёх прямых.
//========================================================
//  Метод находит координаты пересечения двух прямых.
double[] PointFind(double k1, double b1, double k2, double b2)
{
    double[] outArr = new double[2];
    // вычисляем координату X
    outArr[0] = Math.Round(((-b1 + b2) / (k1 - k2)), 2);
    // вычисляем координату Y
    outArr[1] = Math.Round((k2 * outArr[0] + b2), 2);
    return outArr;
}

// Метод вычисляет по двум координатам длину отрезка.
double CalculateDistance(double[] arr1, double[] arr2)
{
    double res = Math.Sqrt(Math.Pow((arr2[0] - arr1[0]), 2) + Math.Pow((arr2[1] - arr1[1]), 2));
    return res;
}

// Метод вычисляет площадь треугольника.
double AreaTriangle(double dist1, double dist2, double dist3)
{
    // находим полупериметр треугольника
    double p = (dist1 + dist2 + dist3) / 2;
    // находим площадь треугольника
    double s = Math.Sqrt(p * (p - dist1) * (p - dist2) * (p - dist3));
    return Math.Round(s, 2);
}

// Метод общих вычислений.
string CalculateArea(int k1, int b1, int k2, int b2, int k3, int b3)
{
    string res = String.Empty;
    if (k1 == k2 || k1 == k3 || k2 == k3) 
        res = "Прямые не образуют треугольника!";
    else
    {
        // находим координаты пересечения трёх прямых
        double[] crossingP1P2 = PointFind(k1, b1, k2, b2);
        double[] crossingP1P3 = PointFind(k1, b1, k3, b3);
        double[] crossingP2P3 = PointFind(k2, b2, k3, b3);

        // находим длину трёх отрезков
        double distance1 = CalculateDistance(crossingP1P2, crossingP1P3);
        double distance2 = CalculateDistance(crossingP1P2, crossingP2P3);
        double distance3 = CalculateDistance(crossingP1P3, crossingP2P3);
        
        // находим площадь треугольника
        double result = AreaTriangle(distance1, distance2, distance3);
        res = ("Площадь треугольника = " + result);
    }
    return res;
}

PrintResult("\n  *Задача.");
PrintResult("\nЗадайте коэффициенты первой прямой P1: ");
int pk1 = ReadData("Введите k1: ");
int pb1 = ReadData("Введите b1: ");
PrintResult("Задайте коэффициенты второй прямой P2: ");
int pk2 = ReadData("Введите k2: ");
int pb2 = ReadData("Введите b2: ");
PrintResult("Задайте коэффициенты третьей прямой P3: ");
int pk3 = ReadData("Введите k2: ");
int pb3 = ReadData("Введите b2: ");

string result = CalculateArea(pk1, pb1, pk2, pb2, pk3, pb3);
PrintResult(result);
