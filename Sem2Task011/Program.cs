//================================================================
// # 11 Напишите программу, которая выводит случайное трёхзначное
// число, а потом удаляет вторую цифру этого числа
//=================================================================

//Variant1
Console.WriteLine("Variant1:");
System.Random numberGenerator = new System.Random();   // создание класса - 8-9 строки, 
int number = numberGenerator.Next(100, 1000);          // 
//int number = new Random().Next(100, 1000);        // либо можно одной строкой
Console.WriteLine(number);
int firstDigit = number / 100;
int thirdDigit = number % 10;
int result = firstDigit * 10 + thirdDigit;
Console.WriteLine(result);

// Variant2
void Variant2()
{
    Console.WriteLine("Variant2:");
    int number = new Random().Next(100, 1000);
    Console.WriteLine(number);
    char[] charArray = number.ToString().ToArray();
    Console.Write(charArray[0]);
    Console.WriteLine(charArray[2]);
}
Variant2();

// Variant3
void Variant3()
{
    Console.WriteLine("Variant3:");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);
    Console.WriteLine(number);
    char[] charArray = number.ToString().ToArray();
    Console.WriteLine("" + charArray[0] + charArray[2]);
}
Variant3();