//=======================================================
// # Задача 60 Сформируйте трёхмерный массив из 
// неповторяющихся двухзначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя
// индексы каждого элемента.
//=======================================================
// Печать результата.
void PrintData(string line)
{
    Console.WriteLine(line);
}

// Метод заполнение трёхмерного массива случайными числами.
int[,,] Fill3DArray(int numXCoord, int numYCoord, int numZCoord , int downBorder, int topBorder)
{
    System.Random rand = new System.Random();
    int[,,] array3D = new int[numXCoord, numYCoord, numZCoord];
    for (int i = 0; i < numXCoord; i++)
    {
        for (int j = 0; j < numYCoord; j++)
        {
            for (int k = 0; k < numZCoord; k++)
                {
                    array3D[i,j,k] = rand.Next(downBorder, topBorder);
                }
        }
    }
    return array3D;
}

// Печать трёхмерного массива.
void Print3DMatrix(int[,,] matr)
{
    for (int k = 0; k < matr.GetLength(2); k++)
    
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
}

int[,,] array3D = Fill3DArray(2, 2, 2, 10, 99);

PrintData("\nВывод трёхмерного массива:\n");
Print3DMatrix(array3D);
