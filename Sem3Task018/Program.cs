//======================================================================
// # 18 Напишите программу, котораяпо заданному номеру четверти
// показывает диапазон возможных координат точек в этой четверти (X и Y)
//=======================================================================

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

string QuarterCoordinates(int quarterNum)
{
    if (quarterNum == 1)
        return "X > 0 Y > 0";
    if (quarterNum == 2)
        return "X < 0 Y > 0";
    if (quarterNum == 3)
        return "X < 0 Y < 0";
    if (quarterNum == 4)
        return "X > 0 Y < 0";
        return "";
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int quarterNum= ReadData("Введите номер четверти:");
string res = QuarterCoordinates(quarterNum);

PrintResult("Координаты точек в этой четверти " + res);


