namespace AlekseevaDZ6
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
           Console.Write("Введите делимое: ");
            double dividend = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите делитель: ");
            double divisor = Convert.ToDouble(Console.ReadLine());

            while (divisor == 0)
            {
                Console.Write("На ноль делить нельзя. Повторите ввод делителя: ");
                divisor = Convert.ToDouble(Console.ReadLine());
            }

            double result = dividend / divisor;
            Console.WriteLine($"Результат: {result}");
        }
    }
}
