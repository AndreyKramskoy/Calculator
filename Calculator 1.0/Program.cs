using System;
using System.Text;

namespace Calculator 
{ /*
   * Калькулятор
   */
    class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("В данном калькуляторе Вы можете произвести операции \"+\", \"-\", \"/\", \"*\". \n Для продолжения действия нажмите \"Enter\". \n Дробные числа разделяются \".\"");

            double a, c;

            Console.WriteLine("Введите первое число");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите необходимую операцию");
            string b = Console.ReadLine();

            Console.WriteLine("Введите второе число");
            c = double.Parse(Console.ReadLine());

            switch (b)
            {
                case "+":
                    double RESULT = (a + c);
                    Console.WriteLine("Ответ: " + RESULT);
                    break;
                case "-":
                    double RESULT1 = (a - c);
                    Console.WriteLine("Ответ: " + RESULT1);
                    break;
                case "*":
                    double RESULT2 = (a * c);
                    Console.WriteLine("Ответ: " + RESULT2);
                    break;
                case "/":
                    if (c == 0)
                        Console.WriteLine("Ответ: 0");
                    else
                    {
                        double RESULT3 = (a / c);
                        Console.WriteLine("Ответ: " + RESULT3);
                    }
                    break;
            }
            Console.ReadLine();

        }
    }
}