string? inputLineA = Console.ReadLine();         // Вводим число

if (inputLineA != null)                          // Прверяем на null
{
    int inputNumberA = int.Parse(inputLineA);    // Делаем целым
    int numberR = inputNumberA % 2;              // Присваиваем R переменной результат деления
    if (numberR == 0)                            // Если = 0, то
    { 
        Console.WriteLine("Чётное");                 // Выводим на экран это сообщение
    }
    else                                         // Если != 0, то
    {
        Console.WriteLine("Нечётное");               // Выводим это сообщение
    }
}