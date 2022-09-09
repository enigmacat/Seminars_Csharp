//==================================================================
// # 20 Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве
//==================================================================

int ReadData(string line)   // чтение данных из консоли
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

double DotDistance(int x1, int y1, int x2, int y2)
{     // расстояние между двумя точками в 2D пространстве
    return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
}
      // Выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x1 = ReadData("Введите координаты x1");
int y1 = ReadData("Введите координаты y1");
int x2 = ReadData("Введите координаты x2");
int y2 = ReadData("Введите координаты y2");
// преобразовываем в строку с округлением
string res = Math.Round(DotDistance(x1,y1,x2,y2),3).ToString();  
PrintResult("Расстояние между точками " + res);
