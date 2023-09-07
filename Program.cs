using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("\tЗадача №1");
                string word1 = "Мир", word2 = "Труд", word3 = "Май";
                Console.WriteLine($"{word1} {word2} {word3}");
                Console.WriteLine($"\t{word1} \n\t\t{word2} \n\t\t\t{word3}");
                Console.ReadKey();

            }
            {
                Console.WriteLine("\tЗадача №3.");
                Console.WriteLine("Введите значение радиуса окружности:");
                double R = Convert.ToDouble(Console.ReadLine());
                double C = 2 * Math.PI * R;
                double S = Math.PI * Math.Pow(R, 2);
                Console.WriteLine($"S={S}, C={C}");
                Console.ReadKey();
            }
            {
                Console.WriteLine("\tЗадача №4. Найти значение y=cos(x)");
                Console.WriteLine("Введите значение x в градусах:");
                double x1 = Convert.ToDouble(Console.ReadLine());
                double x = (x1 * Math.PI) / 180;
                double y = Math.Cos(x);
                Console.WriteLine($"{y}");
                Console.ReadKey();
            }
            {
                Console.WriteLine("\tЗадача №5. Решение квадратного уравнения");
                Console.WriteLine($"Введите коэффициенты a, b, c:");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());
                double D = Math.Pow(b, 2) - 4 * a * c;
                if (D > 0)
                {
                    double x1 = -b + Math.Sqrt(D) / 2 * a;
                    double x2 = -b - Math.Sqrt(D) / 2 * a;
                    Console.WriteLine($"{x1}, {x2}");
                }
                else if (D == 0)
                {
                    double x1 = -b / 2 * a;
                    double x2 = x1;
                    Console.WriteLine($"{x1}, {x2}");
                }
                else
                {
                    Console.WriteLine("\tУравнение не имеет решений.");
                }
                Console.ReadKey();
            }
            {
                /*
                 * а) b присвоить значение c, а присвоить значение b, с присвоить значение а;" +
                "b) b присвоить значение а, с присвоить значение b, а присвоить значение с."
                */
                Console.WriteLine("\tЗадание 6.");
                Console.WriteLine("Введите число a:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите число b:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите число c:");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"a = {a}, b = {b}, c  = {c}");
                {
                    double buffer = a;
                    a = b;
                    b = c;
                    c = buffer;
                    Console.WriteLine($" a = {a}, b = {b}, c = {c}");
                }
                {
                    double buffer = a;
                    a = c;
                    b = a;
                    c = b;
                    Console.WriteLine($"a = {a}, b = {b}, c = {c}");
                }
                Console.ReadKey();
            }
            {
                Console.WriteLine("\tЗадание №7. Вывести 4 рандомных числа");
                Random random = new Random();
                float n1 = random.Next(1, 1000);
                Console.WriteLine($"{n1}");
                float n2 = random.Next(1, 1000);
                Console.WriteLine($"{n2}");
                float n3 = random.Next(1, 1000);
                Console.WriteLine($"{n3}");
                float n4 = random.Next(1, 1000);
                Console.WriteLine($"{n4}");
                Console.ReadKey();
            }
            {
                Console.WriteLine("\tЗадание №8.");
                Console.WriteLine("Введите трёхзначное число:");
                int a = Convert.ToInt32(Console.ReadLine());
                int x = a % 10; // последняя цифра
                int y = a / 10;
                Console.WriteLine($"{x}{y}");
                Console.ReadKey();
            }
            {
                Console.WriteLine("\tЗадание №9. Известна стоимость 1 кг конфет, 1 кг печенья и 1 кг яблок. Найти S стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.");
                Console.WriteLine("Введите значение x:");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение y:");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение z:");
                double z = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"x = {x} кг, y = {y} кг, z = {z} кг");
                double a = 300; // price of sweets
                double b = 170; // price of cookies
                double c = 210; // price of apples 
                Console.WriteLine($"стоимость за кг конфет a = {a} рублей,стоимость за кг печенья b = {b} рублей, стоимость за кг яблок c = {c} рублей");
                double S = a * x + b * y + c * z; // sum 
                Console.WriteLine($"S = {S} рублей");
                Console.ReadKey();
            }

        }
        
           
        
}
}
