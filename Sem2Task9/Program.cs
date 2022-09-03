//====================================================================
// # 9 напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа.
//===================================================================



void Variant1()
{
    Console.WriteLine("method 1");

    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;

    // Variant 1
    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}

void Variant2()                              // Тернарный оператор
{
Console.WriteLine("method 2");

    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;

      
      // Тернарный оператор  
    Console.WriteLine((firstDigit > secondDigit) ? firstDigit : secondDigit);
}

void Variant3()                              // char
{
    Console.WriteLine("method 3");

    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;

    // Variant 3  char
    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);
}

Variant1();

Variant2();

Variant3();