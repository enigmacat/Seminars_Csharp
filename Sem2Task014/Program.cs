//============================================================
// # 14 Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23.
//=============================================================

//Вариант1
Console.Write("Введите число: ");
string inputLineA = Console.ReadLine() ?? "";
int inputNumberA = int.Parse(inputLineA);

if (inputNumberA % 7 == 0 && inputNumberA % 23 == 0)
{
    Console.Write("Число кратно одновременно 7 и 23");
}
else
{
    Console.Write("Число не кратно одновременно 7 и 23");
}

// Вариант2
// int number, resultA, resultB;
// // Запрос числа у пользователя
// // принимает текст запроса и команду выхода "q"
// int RequestNumber(string text = "Введите число", string exitCmd = "q")
// {
//     while (true)
//     {
//         Console.Write(text + ": ");
//         string? inputLine = Console.ReadLine();
//         //игнорируем пробел и любое нечисло
//         if (inputLine == null)
//         {
//             continue;
//         }
//         // выходим из программы
//         if (inputLine.ToLower() == exitCmd)
//         {
//             Environment.Exit(0);
//         }
//         // выдаём полученное число
//         if (int.TryParse(inputLine, out int number))
//         {
//             return number;
//         }
//     }
// }
// // Чтение данных из консоли
// void ReadData()
// {
//     number = RequestNumber("Введите число");
// }
// // Определяем кратность чисел
// void CalculateData()
// {
//     resultA = number % 7;
//     resultB = number % 23;
// }
// // Вывод данных
// void PrintData()
// {
//     if (resultA == 0 && resultB == 0)
//     {
//         Console.WriteLine("Число кратно 7 и 23");
//     }
//     else
//     {
//         Console.WriteLine("Число не кратно 7 и 23");
//     }
// }

// ReadData();
// CalculateData();
// PrintData();

// Вариант3   тернарный оператор
// string? inputLineA = Console.ReadLine();
// if (inputLineA != null)
// Console.Write(((int.Parse(inputLineA) % 7 == 0) && (int.Parse(inputLineA) % 23 == 0)) ? ("Кратно 7 и 23") : ("Не кратно 7 и 23"));
