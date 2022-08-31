string? inputLineA = Console.ReadLine();       // Вводим числа
string? inputLineB = Console.ReadLine();

if (inputLineA != null && inputLineB != null)  // Проверяем на null
{
    int inputNumberA = int.Parse(inputLineA);  // делаем их целыми
    int inputNumberB = int.Parse(inputLineB);

    if (inputNumberA > inputNumberB)           // Если неравенство верно, то
    {
        Console.Write("max = ");               // Выводим это сообщение
        Console.Write(inputLineA);
    }
    else                                        // Иначе, то
    {
        Console.Write("max = ");                // ВЫводим это сообщение
        Console.Write(inputLineB);
    }
}    