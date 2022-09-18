//=============================================================
// # 41 Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
//==============================================================

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
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// считаем кол-во положительных чисел
int CountPos(int M)
{
    int res = 0;
    for (int i = 0; i < M; i++)
    {
        int num = ReadData("Введите число: ");
        if (num > 0) res++;
    }
    return res;
}

int M = ReadData("Введите желаемое количество чисел: ");
int res = CountPos(M);
PrintResult("Количество положительных чисел: " + res);