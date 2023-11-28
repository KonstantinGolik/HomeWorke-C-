// Задача 64: Задайте значения M и N.
// Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

// Console.WriteLine($"Задайте значение M ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Задайте значение N ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{PrintNaturalNumbers(M, N)}");


// string PrintNaturalNumbers(int start, int end)
// {
//     if (end < start | end <= 0)
//     {
//         return "Значение N должно быть больше нуля и больше M";
//     }
//     else if (start <= 0)
//     {
//         if (end == 1)
//         {
//             return end.ToString();
//         }
//         start = 1;
//     }
//     else if (start == end) return start.ToString();
//     return start + "\t" + PrintNaturalNumbers(start + 1, end);
// }


// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.WriteLine($"Задайте значение M ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Задайте значение N ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{SumNaturalNumbers(M, N)}");

// int SumNaturalNumbers(int start, int end)
// {
//     int sum = 0;
//     sum = start + sum;
//     if (end < start | end <= 0)
//     {
//         Console.WriteLine("Значение N должно быть больше нуля и больше M");
//         return 0;
//     }
//     else if (start <= 0)
//     {
//         sum = 0;
//         start = 0;

//     }
//     else if (start == end) return sum;
//     return sum + SumNaturalNumbers(start + 1, end);
// }



