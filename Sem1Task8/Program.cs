string? inputLineN = Console.ReadLine();       // Вводим число
if (inputLineN != null)                        // Проверка на null
{
    int inputNumberN = int.Parse(inputLineN);  // Делаем целым
    int numberB = 2;                           // Присваиваем переменной B первое четное число
    while (numberB <= inputNumberN - 2)            // цикл до тех пор, пока B <= введенному числу
    {
        Console.Write(numberB + ", ");         // Вывод на экран результатов цикла в ряд
        numberB = numberB + 2;                 // увеличиваем В на 2, пока есть соотв. условию цикла
    }
    Console.Write(numberB);
}