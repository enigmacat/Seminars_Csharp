//====================================================================
// # 12 Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому. Если второе 
// число не кратно первому, то программа выводит остаток от деления.
//=====================================================================


int numA = 0;
int numB = 0;
bool result = false;
ReadData();
CalculateData();
PrintData();

// Получаем два числа от пользователя
void ReadData()
{
    Console.Write("Введите первое число: ");
    string inputA = Console.ReadLine()??"";
    Console.Write("Введите второе число: ");
    string inputB = Console.ReadLine()??"";
    numA = int.Parse(inputA);
    numB = int.Parse(inputB);
}
// Определяем кратность чисел
void CalculateData()
{
    result = (numB % numA == 0);
}
// Выводим данные вычисления
void PrintData()
{
    if (result)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("Остаток от деления: " + numB % numA);
    }
}
