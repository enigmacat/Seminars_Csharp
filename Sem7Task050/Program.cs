//=================================================================
// # 50 Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
//=====================================================================

// ввод данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// создаем двумерный массив целых чисел
int[,] Fill2DArray(int countRow, int countCol, int downBorder, int topBorder)
{
    System.Random rand = new System.Random();
    int[,] arr2D = new int[countRow, countCol];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            arr2D[i, j] = rand.Next(downBorder, topBorder + 1);
        }
    }
    return arr2D;
}

// выводим двумерный массив на экран
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// находим элемент в массиве по заданным координатам
int FindElem(int x, int y, int[,] arr)
{
    if (x < arr.GetLength(0) && y < arr.GetLength(1))
    {
        return arr[x, y];
    }
    else
    {
        return -1;
    }
}

// выводим значение найденного эл-та
void PrintNumber(int K)
{
    Console.WriteLine((K != -1) ?
    ("Искомое значение элемента: " + K) :
    "Искомый элемент отсутствует");
}

int x = ReadData("Введите номер строки: ");
int y = ReadData("Введите номер столбца: ");
Console.WriteLine();
int[,] arr = Fill2DArray(10, 10, 10, 99);
int K = FindElem(x, y, arr);
Print2DArray(arr);
Console.WriteLine();
PrintNumber(K);