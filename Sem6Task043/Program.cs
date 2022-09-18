//===================================================================
// # 43  Напишите программу, которая найдёт точку пересечения двух
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
//==================================================================

// чтение данных из консоли
int ReadData(string line)
{
    //Выводим сообщение
    Console.Write(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// выводим результат
void Print1DArr(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// создаем массив с координатами точки пересечения
double[] PointCross(double k1, double k2, double b1, double b2)
{
    double[] outArr = new double[2];

    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    outArr[0] = x;
    outArr[1] = y;

    return outArr;
}

double k1 = ReadData("Введите значение k1: ");
double k2 = ReadData("Введите значение k2: ");
double b1 = ReadData("Введите значение b1: ");
double b2 = ReadData("Введите значение b2: ");

double[] arr = PointCross(k1, k2, b1, b2);

Print1DArr(arr);
