//=====================================================
// # 27 Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
//=====================================================

int ReadData(string line)   // чтение данных из консоли
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
// подсчитываем сумму цифр
int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

int num = ReadData("Введите число: ");
int sum = SumDigit(num);
PrintResult("Сумма цифр в числе равна: " + sum);