//================================================================
// # 19 Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

//=================================================================

int ReadData(string line)   // чтение данных из консоли
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

bool TestPldrm(int pal)   // проверка на палиндром
{
    if (pal / 10000 == pal % 10 && pal / 1000 % 10 == pal / 10 % 10)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PrintData(int pal)
{
    if (TestPldrm(pal))
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
        Console.WriteLine("Это не палиндром");
    }
}

int pal = ReadData("Введите пятизначное число: ");

PrintData(pal);