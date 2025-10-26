namespace AlekseevaDZ6
{
    internal class Program
    {
        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        static double Divide(double a, double b) => a / b;
        static double Power(double a, double b) => Math.Pow(a, b);
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.WriteLine("5. Возведение в степень");
                Console.WriteLine("exit - выход");
                Console.Write("Выберите операцию: ");

                string choice = Console.ReadLine() ?? "";
                if (choice.ToLower() == "exit") break;

                Console.Write("Введите первое число: ");
                double num1 = double.Parse(Console.ReadLine() ?? "0");
                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine() ?? "0");

                double result = choice switch
                {
                    "1" => Add(num1, num2),
                    "2" => Subtract(num1, num2),
                    "3" => Multiply(num1, num2),
                    "4" => Divide(num1, num2),
                    "5" => Power(num1, num2),
                    _ => 0
                };

                Console.WriteLine($"Результат: {result}");
            }
            Console.WriteLine("Калькулятор завершил работу!");
        }
    }
}
