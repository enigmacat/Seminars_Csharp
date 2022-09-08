//====================================================================
// # 12 Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому. Если второе 
// число не кратно первому, то программа выводит остаток от деления.
//=====================================================================

int numA = 0;                // Глобальные переменные, 
int numB = 0;                //   доступ к которым
bool result = false;         //    у всех методов
ReadData();             //Вызоа 
CalculateData();        //  всех 
PrintData();            //    методов.  можно в начале и в конце

// Получаем два числа от пользователя (Ввод)
void ReadData()
{
    Console.Write("Введите первое число: ");
    string inputA = Console.ReadLine() ?? "";
    Console.Write("Введите второе число: ");
    string inputB = Console.ReadLine() ?? "";
    numA = int.Parse(inputA);
    numB = int.Parse(inputB);
}
// Определяем кратность чисел  (Вычисление)
void CalculateData()
{
    result = (numB % numA == 0);
}
// Выводим данные вычисления  (Вывод)
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

// Variant_X

// Console.Write("Введите первое число: ");
// string inputA = Console.ReadLine() ?? "";
// Console.Write("Введите второе число: ");
// string inputB = Console.ReadLine() ?? "";
// int numA = int.Parse(inputA);
// int numB = int.Parse(inputB);

// Console.WriteLine((numB % numA == 0) ? ("Второе число кратно первому") : ("Остаток от деления = " + numB % numA));