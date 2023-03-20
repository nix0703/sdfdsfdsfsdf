using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, result;
            char operacja;

            Console.WriteLine("Podaj Pierwsza Liczbe: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            y = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj Operator (+, -, *, /, ^, r ");
            operacja = char.Parse(Console.ReadLine());

            switch (operacja)
            {
                case '+':
                    result = dodawanie(x, y);
                    Console.WriteLine("{0} + {1} = {2}", x, y, result);
                    break;

                case '-':
                    result = odejmowanie(x, y);
                    Console.WriteLine("{0} - {1} = {2}", x, y, result);
                    break;

                case '*':
                    result = mnożenie(x, y);
                    Console.WriteLine("{0} * {1} = {2}", x, y, result);
                    break;

                case '/':
                    if (y == 0)
                    {
                        Console.WriteLine("Nie mozna dzielic przez zero");
                    }
                    else
                    {
                        result = dzielenie(x, y);
                        Console.WriteLine("{0} / {1} = {2}", x, y, result);
                    }
                    break;

                case '^':
                    result = potęgowanie(x, y);
                    Console.WriteLine("{0} ^ {1} = {2}", x, y, result);
                    break;

                case 'r':
                    result = Math.Sqrt(x);
                    Console.WriteLine("Pierwiastek kwadratowy z liczby " + x + " wynosi: " + result);
                    result = Math.Sqrt(y);
                    Console.WriteLine("Pierwiastek kwadratowy z liczby " + y + " wynosi: " + result);
                    break;
                default:
                    Console.WriteLine("Nieznany operator");
                    break;
            }
            Console.WriteLine("Nacisnij dowolny klawisz aby zakonczyc...");
            Console.ReadKey();
        }

        static double dodawanie(double x, double y)
        {
            return x + y;
        }

        static double odejmowanie(double x, double y)
        {
            return x - y;
        }

        static double mnożenie(double x, double y)
        {
            return x * y;
        }

        static double dzielenie(double x, double y)
        {
            return x / y;
        }

        static double potęgowanie(double x, double y)
        {
            return Math.Pow(x, y);
        }

    }
}
