//========================================================================
// # 4 Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.
//=====================================================================

string? inputLineA = Console.ReadLine();                 // Вводим числа
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();

if (inputLineA != null && inputLineB != null && inputLineC != null) //Проверка на null
{
    int inputNumberA = int.Parse(inputLineA);    // Делаем их целыми 
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);

    if (inputNumberA > inputNumberB)             // Сравниваем А и В, если неравенство верно, то
    {
        if (inputNumberA > inputNumberC)            // Сравниваем А и С, если неравенство верно,то
        {
            Console.Write("max = ");                // выводим сообщение max = A
            Console.Write(inputLineA);
        }
        else                                        // если А < C, то 
        {
            Console.Write("max = ");                // Выводим сообщение max = C
            Console.Write(inputLineC);
        }
    }
    else                                         // Если A < B, то  
    {
        if (inputNumberB > inputNumberC)            // Сравниваем B и C, если неравенство верное
        {
            Console.Write("max = ");                // Выводим max = B, 
            Console.Write(inputNumberB);
        }
        else                                        // Если нет, то
        {
            Console.Write("max = ");                // Выводим сообщение max = C
            Console.Write(inputNumberC);
        }
    }
    // int max = Math.Max(inputNumberA, Math.Max(inputNumberB, inputNumberC));
    // Console.Write("max = ");
    // Console.WriteLine(max);
}