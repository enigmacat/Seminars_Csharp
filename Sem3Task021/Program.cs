//======================================================================
// # 21 Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
//=======================================================================

int ReadData(string line)   // чтение данных из консоли
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

double DotDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{     // расстояние между двумя точками в 3D пространстве
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

void PrintResult(string line)    // Выводим результат
{
    Console.WriteLine(line);
}

int x1 = ReadData("Введите координаты x1");
int y1 = ReadData("Введите координаты y1");
int z1 = ReadData("Введите координаты z1");
int x2 = ReadData("Введите координаты x2");
int y2 = ReadData("Введите координаты y2");
int z2 = ReadData("Введите координаты z2");

// преобразовываем в строку с округлением
string res = Math.Round(DotDistance(x1, y1, z1, x2, y2, z2), 3).ToString();
PrintResult("Расстояние между точками " + res);
