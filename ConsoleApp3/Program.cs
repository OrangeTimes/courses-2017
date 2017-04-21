using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            //int Example1Result = -1 + 3 * 5;
            //int Example2Result = (24 + 5) % 7;
            //double Example3Result = 15 + -4 * 6 / 11;
            //double Example4Result = 2 + 10 / 6 * 1 - 7 % 2;

            //Console.WriteLine("Example1Result: " + Example1Result);
            //Console.WriteLine("Example2Result: " + Example2Result);
            //Console.WriteLine("Example3Result: " + Example3Result);
            //Console.WriteLine("Example4Result: " + Example4Result);
            //Console.ReadKey();

            //2.
            char again = 'д';
            while (again == 'д')
            {
                double a;
                double b;
                double total;
                char oper;

                Console.WriteLine("Enter :");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите оператор:");
                oper = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                b = Convert.ToDouble(Console.ReadLine());

                if (oper == '+')
                {
                    total = a + b;
                    Console.WriteLine("Сумма {0} {1} равно {2}.", a, b, total);
                }

                else if (oper == '-')
                {
                    total = a - b;
                    Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
                }

                else if (oper == '*')
                {
                    total = a * b;
                    Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
                }

                else if (oper == '/')
                {
                    total = a / b;
                    Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
                }
                else
                {
                    Console.WriteLine("Неизвестный оператор.");
                }
                Console.WriteLine();
                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)");
                again = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
