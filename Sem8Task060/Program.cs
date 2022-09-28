//============================================================================
// # 60 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя
// индексы каждого элемента.
//===============================================================================

// создание трехмерного массива
int[,,] Generate3DArray(int countX, int countY, int countZ, int start, int stop)
{
    Random rand = new Random();
    int[,,] arr = new int[countX, countY, countZ];
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                arr[x, y, z] = rand.Next(start, stop + 1);
            }
        }
    }
    return arr;
}

// Печать трёхмерного массива c индексами элементов
void Print3DArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write(matr[i, j, k] + " (" + i + j + k + ") ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] arr3D = Generate3DArray(3, 3, 3, 0, 9);
Print3DArray(arr3D);


