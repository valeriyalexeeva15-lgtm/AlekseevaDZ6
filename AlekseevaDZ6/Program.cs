namespace AlekseevaDZ6
{
    using System;
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите целое число: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Вы ввели: {number}");
                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка! Введите корректное целое число.");
                }
            }
        }
    }
}