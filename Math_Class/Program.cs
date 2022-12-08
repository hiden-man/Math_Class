using System;
/*
 * Lesson 8 Math Class (Bro Code tutorials)
 */
namespace Math_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            usingMathClass();
        }
        static void usingMathClass()
        {
            Console.WriteLine(Math.Pow(4, 3)); // Визначення числа в степені (число 4 в степені 3)
            Console.WriteLine(Math.Sqrt(256)); // Вивод квадратного корення числа в дужках
            Console.WriteLine(Math.Abs(-38)); // Перетворює від'ємне число в додатнє
            Console.WriteLine(Math.Round(43.685)); // Округлює число в більшу сторону
            Console.WriteLine(Math.Round(43.354)); // Просто округлює число
            Console.WriteLine(Math.Ceiling(5.83)); // Повертає найменше ціле значення, більше або дорівнює вказаному числу
            Console.WriteLine(Math.Ceiling(5.23));
            Console.WriteLine(Math.Ceiling(-5.23));
            Console.WriteLine(Math.Max(193, 59)); // знаходить найбільше значення
            Console.WriteLine(Math.Min(193, 59)); // знаходить найменше значення
        }
    }
}
