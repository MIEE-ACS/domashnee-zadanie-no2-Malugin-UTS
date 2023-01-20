using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double segment1(double x)
        {
            double y;
            y = -x;
            return y;
        }
        static double segment2(double x)
        {
            return 0;
        }
        static double segment3(double x, double r)
        {
            double a = 3;
            double y;
            y = Math.Sqrt(r * r - (x - a) * (x - a));
            return y;
        }
        static double segment4(double x)
        {
            double y;
            y = -0.5 * x + 2.5;
            return y;
        }
        static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine("Ведите R:");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Ведите X:");
            for (double x = double.Parse(Console.ReadLine()); x <= 7; x += 0.2)
            {
                if (r < 2)
                {

                    if (x < -3)
                    {
                        Console.WriteLine("Функция не определена ");
                    }
                    else if (x >= -3 && x < 0)
                    {
                        Console.WriteLine("X({0:0.00}) = {1:0.00}", x, segment1(x));
                    }
                    else if (x >= 0 && x <= 1)
                    {
                        Console.WriteLine("X({0:0.00}) = {1:0.00}", x, segment2(x));
                    }
                    else if (x > 1 && x < 5)
                    {
                        Console.WriteLine($" разрыв от  x={x} до a-r={a - r}");
                        Console.Write($"разрыв от  a+r={a + r} до a+2r={a + 2 * r}");
                        break;

                    }

                    else if (x >= 5 && x <= 7)
                    {
                        Console.WriteLine("X({0:0.00}) = {1:0.00}", x, segment4(x));
                    }
                }
                else if (r == 2)
                {
                    if (x < -3)
                    {
                        Console.WriteLine("Функция не определена ");
                    }
                    else if (x >= -3 && x < 0)
                    {
                        Console.WriteLine("X({0:0.00}) = {1:0.00}", x, segment1(x));
                    }
                    else if (x >= 0 && x <= 1)
                    {
                        Console.WriteLine("X({0:0.00}) = {1:0.00}", x, segment2(x));
                    }
                    else if (x > 1 && x < 5)
                    {
                        Console.WriteLine("X({0:0.00}) = {1:0.00}", x, segment3(x, r));
                    }
                    else if (x >= 5 && x <= 7)
                    {
                        Console.WriteLine("X({0:0.00}) = {1:0.00}", x, segment4(x));
                    }

                }
                else if (r > 2)
                {
                    if (x < -3)
                    {
                        Console.WriteLine("Функция не определена ");
                    }
                    else if (x >= -3 && x < 0)
                    {
                        Console.WriteLine("X({0:0.00}) = {1:0.00}", x, segment1(x));
                    }
                    else if (x >= 0 && x <= 1)
                    {
                        Console.WriteLine("X({0:0.00}) = {1:0.00}", x, segment2(x));
                    }
                    else if (x > 1 && x < 5)
                    {
                        Console.WriteLine("X({0:0.00}) = {1:0.00}", x, segment3(x, r));
                    }
                    else if (x >= 5 && x <= 7)
                    {
                        Console.WriteLine("X({0:0.00}) = {1:0.00}", x, segment4(x));
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
