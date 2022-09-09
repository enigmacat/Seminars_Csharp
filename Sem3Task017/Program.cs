//=================================================================
// # 17 Наишите программу, которая принимает на вход координаты
// точки (X и Y), причём X != 0  Y != 0 и выдаёт номер четверти
// плоскости, в которой находится эта точка.
//=====================================================================

// чтение данных из консоли
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

int QuarterTest(int X, int Y)
{
    if (X > 0 && Y > 0)
        return 1;
    if (X < 0 && Y > 0)
        return 2;
    if (X < 0 && Y < 0)
        return 3;
    if (X > 0 && Y < 0)
        return 4;

        return -1;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int X = ReadData("Введите координату X:");
int Y = ReadData("Введите координату Y:");
int res = QuarterTest(X, Y);

PrintResult("Точка находится в четверти " + res);