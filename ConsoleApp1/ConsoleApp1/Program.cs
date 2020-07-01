using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действие, которое хотите совершить: ");
            Console.WriteLine("1 - сложение\n2 - вычитание\n3 - умножение\n4 - деление\n5 - квадратный корень числа\n6 - возведение числа в степень");
            int str = Convert.ToInt32(Console.ReadLine());
            if (str == 5)
            {
                Console.WriteLine("Введите число: ");
                double с = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Результат: {0}", Math.Sqrt(с));
            }

            if (str > 0 && str < 7 && str != 5)
            {
                Console.Write("Введите Первое число: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите Второе число: ");
                double b = Convert.ToDouble(Console.ReadLine());

                double result;
                switch (str)
                {
                    case 1:
                        {
                            result = a + b;
                            Console.WriteLine("Результат: {0}", result);
                            break;
                        }
                    case 2:
                        {
                            result = a - b;
                            Console.WriteLine("Результат: {0}", result);
                            break;
                        }
                    case 3:
                        {
                            result = a * b;
                            Console.WriteLine("Результат: {0}", result);
                            break;
                        }
                    case 4:
                        {
                            result = a / b;
                            Console.WriteLine("Результат: {0}", result);
                            break;
                        }
                    case 6:
                        {
                            result = Math.Pow(a, b);
                            Console.WriteLine("Результат: {0}", result);
                            break;
                        }
                }
            }
            else if (str == 5) Console.WriteLine();
            else Console.WriteLine("Ввели неверное действие!!!");

            Console.ReadLine();
        }
    }
}
