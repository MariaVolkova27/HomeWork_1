// Задача. Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b,
// введенные из командной строки, и выводящую результат выполнения на экран.

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                if (double.TryParse(args[0], out double num1) && double.TryParse(args[2], out double num2))
                {
                    double result = 0;
                    switch (args[1])
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "/":
                            result = num1 / num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;                        
                    }
                    Console.WriteLine($"{num1} {args[1]} {num2} = {result}");
                }
            }                      
        }
    }
}



