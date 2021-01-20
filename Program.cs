using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание №1

            double a = 16.80;
            double b = 12.40;

            double result = Math.Sqrt(a*b);
            System.Console.WriteLine("Результат: " + result);

            //Задание №2

            decimal A = 1.40m;
            decimal B = -5.50m;
            decimal C = 0.60m;
            
            decimal AC = A - C;
            decimal BC = C - B;
            decimal summa = AC + BC;

            System.Console.WriteLine("АС = " + AC);
            System.Console.WriteLine("ВС = " + BC);
            System.Console.WriteLine("Результат: " + summa);

            //Задание №3

            double x1 = -6.20;
            double y1 = 5.20;
            double x2 = 2.10;
            double y2 = 9.80;

            double rastoyanie = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2-y1),2));
            System.Console.WriteLine("Результат: " + rastoyanie);

            //Задание №4

            int z = 41;
            int x = z / 10;
            int v = (z % 10)*10;
            int resul = v + x;

            System.Console.WriteLine("Результат: " + resul);
            
            //Задание №5

            int N = 10985;
            int second = N / 60;

            System.Console.WriteLine("Результат: " + second);

            //Задание №6

            int K = 202;
            int n = K  % 7;
            
            if (n==0)
            {
                System.Console.WriteLine("Номер дня недели: 0 - Воскресенье");
            }
            else if (n==1)
            {
                System.Console.WriteLine("Номер дня недели: 1 - Понедельник");
            }
            else if (n==2)
            {
                System.Console.WriteLine("Номер дня недели: 2 - Вторник");
            }
            else if (n==3)
            {
                System.Console.WriteLine("Номер дня недели: 3 - Среда");
            }
            else if (n==4)
            {
                System.Console.WriteLine("Номер дня недели: 4 - Четверг");
            }
            else if (n==5)
            {
                System.Console.WriteLine("Номер дня недели: 5 - Пятница");
            }
            else if (n==6)
            {
                System.Console.WriteLine("Номер дня недели: 6 - Суббота");
            }
        }
    }
}
