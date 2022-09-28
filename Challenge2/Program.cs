class Programm
{
    struct Direction
    {
        public int i;
        public int j;
    }

    static void Main(string[] args)
    {
        int row = ReadData("Введите количество строк: ");
        int col = ReadData("Введите количество колонок: ");



        DateTime d2 = DateTime.Now;
        int[,] matrix2 = GenSperalArray(row, col);
        PrintResult("Решение Юрия " + (DateTime.Now - d2));
        //Print2DArray(matrix2);

        DateTime d3 = DateTime.Now;
        int[,] matrix3 = SpiralFill2DArray(row, col);
        PrintResult("Решение Андрей " + (DateTime.Now - d3));
        //Print2DArray(matrix3);

        DateTime d4 = DateTime.Now;
        int[,] matrix4 = Fill2DArray(row, col);
        PrintResult("Решение Максим " + (DateTime.Now - d4));
        //Print2DArray(matrix4);

        DateTime d1 = DateTime.Now;
        int[,] matrix1 = Fill2DArraySpiral(row, col);
        PrintResult("Решение Константина " + (DateTime.Now - d1));
        //Print2DArray(matrix1);
    }


    // Константин Пивнов
    // Метод генерации и заполнения двумерного массива спирально
    static int[,] Fill2DArraySpiral(int rows, int cols)
    {
        int[,] array2D = new int[rows, cols];

        int row = 0; int col = 0; // Счётчики по массиву
        int dX = 1; int dY = 0; // Изменения счётчиков row и col на каждом шаге
        int steps = cols; // Количество шагов до поворота
        int dirChangeCount = 0; // Количество осуществлённых поворотов

        for (int i = 0; i < rows * cols; i++)
        {
            // Заполняем текущий элемент массива, уменьшаем счётчик шагов
            array2D[row, col] = i + 1;
            steps--;

            // Если шагов в текущем направлении не осталось - меняем направление
            if (steps == 0)
            {
                int buf = dX;
                dX = -dY;
                dY = buf;
                steps = Math.Abs(dY) * rows + Math.Abs(dX) * cols - (dirChangeCount / 2 + 1); // Вычисляем количество предстоящих шагов
                dirChangeCount++;
            }

            row += dY;
            col += dX;
        }

        return array2D;
    }

    //Кирсанов Юрий
    // Объявляю глобальные переменные для цикла


    static int[,] GenSperalArray(int rows, int columns)
    {


        int[,] array = new int[rows, columns];
        Direction direct = new Direction() { i = 0, j = 1 };
        int count = 0;

        int i = 0, j = 0;
        while (count < rows * columns)
        {
            while ((i < rows) && (i >= 0) && (j < columns) && (j >= 0))
            {
                if (array[i, j] == 0)
                {
                    count++;
                    array[i, j] = count;
                    i += direct.i;
                    j += direct.j;
                }
                else
                {
                    if (count == columns * rows) break;
                    i -= direct.i;
                    j -= direct.j;
                    ChangeDirection(ref direct);
                    i += direct.i;
                    j += direct.j;
                }
            }

            if (i < 0) i = 0;
            if (i >= rows) i = rows - 1;
            if (j < 0) j = 0;
            if (j >= columns) j = columns - 1;
            ChangeDirection(ref direct);
            i += direct.i;
            j += direct.j;
        }
        return array;
    }

    static void ChangeDirection(ref Direction direct)
    {
        switch (direct.i)
        {
            case -1:
                direct.i = 0;
                direct.j = 1;
                break;
            case 1:
                direct.i = 0;
                direct.j = -1;
                break;
            case 0:
                if (direct.j > 0)
                {
                    direct.i = 1;
                    direct.j = 0;
                }
                else
                {
                    direct.i = -1;
                    direct.j = 0;
                }
                break;
        }
    }


    //Андрей Кулеш
    // Метод спирального заполнение двумерного массива числами.
    static int[,] SpiralFill2DArray(int row, int col)
    {
        int[,] arr2D = new int[row, col];
        int n = row; // строки
        int m = col; // столбцы
                     // границы заполнения
        int ibeg = 0, ifin = 0, jbeg = 0, jfin = 0;

        int count = 1; // счётчик заполнения
        int i = 0; // старт строк
        int j = 0; // старт столбцов

        while (count <= n * m)
        {
            arr2D[i, j] = count;
            if (i == ibeg && j < m - jfin - 1)
                j++;
            else if (j == m - jfin - 1 && i < n - ifin - 1)
                i++;
            else if (i == n - ifin - 1 && j > jbeg)
                j--;
            else
                i--;

            if ((i == ibeg + 1) && (j == jbeg) && (jbeg != m - jfin - 1))
            {
                ibeg++;
                ifin++;
                jbeg++;
                jfin++;
            }
            count++;
        }
        return arr2D;
    }

    //Максим Баранцев
    // Заполняем массив случайными числами
    static int[,] Fill2DArray(int row, int col)
    {
        int[,] matr = new int[row, col];
        int index = 1;
        int j = 0;
        int n = matr.GetLength(0);
        for (int i = 1; i <= n; i++)
        {
            for (j = i - 1; j < n - i + 1; j++)
            {
                matr[i - 1, j] = index++;
            }
            for (j = i; j < n - i + 1; j++)
            {
                matr[j, n - i] = index++;
            }
            for (j = n - i - 1; j >= i - 1; j--)
            {
                matr[n - i, j] = index++;
            }
            for (j = n - i - 1; j >= i; j--)
            {
                matr[j, i - 1] = index++;
            }
        }
        return matr;
    }

    // Печать двумерного массива
    static void Print2DArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    // Чтение данных из консоли
    static int ReadData(string line)
    {
        Console.Write(line);
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
    }

    // Метод, принимает строку, выводит в консоль
    static void PrintResult(string line)
    {
        Console.WriteLine(line);
    }
}
