using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("задание 1.1");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:F2}", num1);

            Console.WriteLine("задание 1.2");
            Console.WriteLine(Math.Round(Math.Exp(1), 1));

            Console.WriteLine("задание 1.3");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели число {0}", num3);
            

            Console.WriteLine("задание 1.4");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num4 + " вот какое число Вы ввели");
            
            
            Console.WriteLine("задание 1.5");
            Console.WriteLine("1 13 49");

            
            Console.WriteLine("задание 1.6");
            Console.WriteLine("7  15  100");

            Random rnd = new Random();
            Console.WriteLine("задание 1.7");
            Console.WriteLine(rnd.Next() + " " + " " + rnd.Next() + " " + " " + rnd.Next());

            Console.WriteLine("задание 1.8");
            Console.WriteLine("{0} {1} {2} {3}", rnd.Next(), rnd.Next(), rnd.Next(), rnd.Next());

            Console.WriteLine("задание 1.9");
            Console.Write("50 \n" + "10 \n");

            Console.WriteLine("задание 1.10");
            Console.Write("5 \n" + "10 \n" + "21 \n");

            Console.WriteLine("задание 1.11");
            Console.WriteLine("{0} \n {1} \n {2} \n {3} \n", rnd.Next(), rnd.Next(), rnd.Next(), rnd.Next(), rnd.Next());

            Console.WriteLine("задание 1.12");
            Console.WriteLine("5 10 \n" + "7 см");

            Console.WriteLine("задание 1.13");
            Console.WriteLine("2 кг \n" + "13 17");

            Console.WriteLine("задание 2.1 (a)");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 7 * x * x + 3 * x + 6;
            Console.WriteLine("Решение = " + y);

            Console.WriteLine("задание 2.1 (б)");
            double a = Convert.ToDouble(Console.ReadLine());
            x = 12 * a * a + 7 * a + 12;
            Console.WriteLine("Решение = " + x);

            Console.WriteLine("задание 2.2");
            double storona = Convert.ToDouble(Console.ReadLine());
            double perimetr = 4 * storona;
            Console.WriteLine("Периметр = " + perimetr);

            Console.WriteLine("задание 2.3");
            double radius = Convert.ToDouble(Console.ReadLine());
            double diametr = 2 * radius;
            Console.WriteLine("Диаметр = " + diametr);

            Console.WriteLine("задание 2.4");
            int R = 6350;
            double h = Convert.ToDouble(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow((R + h), 2)- R * R);
            Console.WriteLine("Расстояние до линии горизонта = " + distance);

            Console.WriteLine("задание 2.5");
            double rebro = Convert.ToDouble(Console.ReadLine());
            double V = Math.Pow(rebro, 3);
            double S = 4 * Math.Pow(rebro, 2);
            Console.WriteLine("Объем = {0} \n Площадь боковой поверхности = {1}", V, S);

            Console.WriteLine("задание 2.6");
            double R1 = Convert.ToDouble(Console.ReadLine());
            double dlina = 2 * Math.PI * R1;
            double s = Math.PI * Math.Pow(R1,2);
            Console.WriteLine("Длина окружности = " + dlina);
            Console.WriteLine("Площадь окружности = " + s);

            Console.WriteLine("задание 2.7");
            double num_1 = Convert.ToDouble(Console.ReadLine()), num_2 = Convert.ToDouble(Console.ReadLine());
            double sr_ar = (num_1 + num_2) / 2;
            double sr_gm = Math.Sqrt(num_1 * num_2);
            Console.WriteLine("Среднее арифметическое = {0} \n Среднее геометрическое = {1}", sr_ar, sr_gm);

            Console.WriteLine("задание 2.8");
            int V1 = rnd.Next(), m = rnd.Next();
            int p = m / V1;
            Console.WriteLine("Плотность = " + p);

            Console.WriteLine("задание 2.9");
            int Count = rnd.Next(), square = rnd.Next();
            p = Count / square;
            Console.WriteLine("Плотность = " + p);

            Console.WriteLine("задание 2.10");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            if (a1 == 0)
                Console.WriteLine("Нет решений");
            else
            {
                x = -b1 / a1;
                Console.WriteLine("Решение {0}", x);
            }

            Console.WriteLine("задание 2.11");
            double catet1 = Convert.ToDouble(Console.ReadLine());
            double catet2 = Convert.ToDouble(Console.ReadLine());
            double gipotenuza = Math.Sqrt(Math.Pow(catet1, 2) + Math.Pow(catet2, 2));
            Console.WriteLine("Гипотенуза = " + gipotenuza);

            Console.WriteLine("задание 2.12");
            double r_2 = Convert.ToDouble(Console.ReadLine());
            double r_1= Convert.ToDouble(Console.ReadLine());
            double Square;
            if (r_1 > r_2)
            {
                Square = Math.PI * Math.Pow(r_1, 2) - Math.PI * Math.Pow(r_2, 2);
                Console.WriteLine("Площадь кольца = " + Square);
            }
            else if (r_1 == r_2)
                Console.WriteLine("Нет решения");
            else
            {
                Square = Math.PI * Math.Pow(r_2, 2) - Math.PI * Math.Pow(r_1, 2);
                Console.WriteLine("Площадь кольца = " + Square);
            }

            Console.WriteLine("задание 2.13");
            double cat1 = Convert.ToDouble(Console.ReadLine());
            double cat2 = Convert.ToDouble(Console.ReadLine());
            double gipotenuza1 = Math.Sqrt(Math.Pow(cat1, 2) + Math.Pow(cat2, 2));
            perimetr = cat1 + cat2 + gipotenuza1;
            Console.WriteLine("Периметр = " + perimetr);

            Console.WriteLine("задание 2.13A");
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            double sr_arf = (Math.Abs(number1) + Math.Abs(number2)) / 2;
            double sr_geom = Math.Sqrt(Math.Abs(number1) * Math.Abs(number2));
            Console.WriteLine("Среднее арифметическое = {0} \n Среднее геометрическое = {1}", sr_arf, sr_geom);

            Console.WriteLine("задание 2.14");
            double osn_1 = Convert.ToDouble(Console.ReadLine());
            double osn_2 = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());
            double bok;
            if (osn_1 > osn_2)
            {
                bok = Math.Sqrt(Math.Pow(height, 2) + Math.Pow((osn_1 - osn_2) / 2, 2));
                perimetr = 2 * bok + osn_1 + osn_2;
                Console.WriteLine("Периметр = " + perimetr);
            }
            else
            {
                bok = Math.Sqrt(Math.Pow(height, 2) + Math.Pow((osn_2 - osn_1) / 2, 2));
                perimetr = 2 * bok + osn_1 + osn_2;
                Console.WriteLine("Периметр = " + perimetr);
            }

            Console.WriteLine("задание 2.14А");
            double storona1 = Convert.ToDouble(Console.ReadLine());
            double storona2 = Convert.ToDouble(Console.ReadLine());
            double diagonal = Math.Sqrt(Math.Pow(storona1, 2) + Math.Pow(storona2, 2));
            perimetr = 2 * storona1 + 2 * storona2;
            Console.WriteLine("Периметр {0} \n Диагональ {1}", perimetr, diagonal);

            Console.WriteLine("задание 2.15");
            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());
            double summa = n1 + n2;
            double raznost = Math.Abs(n1 - n2);
            double mult = n1 * n2;
            double div = n1 / n2;
            Console.WriteLine("Сумма = {0} \n Разность = {1} \n Произведение = {2} \n Частное = {3}", summa, raznost, mult, div);

            Console.WriteLine("задание 2.16");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            V = a2 * b2 * c2;
            S = 2 * a2 * b2 + 2 * a2 * c2;
            Console.WriteLine("Объем = {0} \n Площадь боковой поверхности = {1}", V, S);

            Console.WriteLine("задание 2.17");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double len = Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));
            Console.WriteLine("Расстояние между точками = " + len);

            Console.WriteLine("задание 2.18");
            Console.WriteLine("Задание 2.18 такое же как и задание 2.14, так что можно посмотреть решение выше <3");

            Console.WriteLine("задание 2.19");
            double osn1 = Convert.ToDouble(Console.ReadLine());
            double osn2 = Convert.ToDouble(Console.ReadLine());
            double injection = Convert.ToDouble(Console.ReadLine());
            double cos_in = Math.Cos(injection * Math.PI / 180);
            double c = Math.Abs(osn1 - osn2) / 2;
            bok = c / cos_in;
            h = Math.Sqrt(Math.Pow(bok, 2) - Math.Pow(c, 2));
            Square = ((osn1 + osn2) / 2) * h;
            Console.WriteLine("Площадь трапеции = " + Square);


            Console.WriteLine("задание 2.20");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            double stor1 = Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));
            double stor2 = Math.Sqrt(Math.Pow(Math.Abs(x2 - x3), 2) + Math.Pow(Math.Abs(y2 - y3), 2));
            double stor3 = Math.Sqrt(Math.Pow(Math.Abs(x1 - x3), 2) + Math.Pow(Math.Abs(y1 - y3), 2));
            perimetr = stor1 + stor2 + stor3;
            Square = Math.Sqrt(perimetr * (perimetr - stor1) * (perimetr - stor2) * (perimetr - stor3));
            Console.WriteLine("Периметр треугольника = {0} \n Площадь треугольника =  {1}", perimetr, Square);

            Console.WriteLine("задание 2.21");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            x3 = Convert.ToDouble(Console.ReadLine());
            y3 = Convert.ToDouble(Console.ReadLine());
            double x4 = Convert.ToDouble(Console.ReadLine());
            double y4 = Convert.ToDouble(Console.ReadLine());
            stor1 = Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));
            stor2 = Math.Sqrt(Math.Pow(Math.Abs(x2 - x3), 2) + Math.Pow(Math.Abs(y2 - y3), 2));
            stor3 = Math.Sqrt(Math.Pow(Math.Abs(x3 - x4), 2) + Math.Pow(Math.Abs(y3 - y4), 2));
            double stor4 = Math.Sqrt(Math.Pow(Math.Abs(x1 - x4), 2) + Math.Pow(Math.Abs(y1 - y4), 2));
            diagonal = Math.Sqrt(Math.Pow(Math.Abs(x1 - x3), 2) + Math.Pow(Math.Abs(y1 - y3), 2));
            double perimetr1 = stor1 + stor2 + diagonal;
            double perimetr2 = stor3 + stor4 + diagonal;
            Square = Math.Sqrt(perimetr1 * (perimetr1 - stor1) * (perimetr1 - stor2) * (perimetr1 - diagonal)) + Math.Sqrt(perimetr2 * (perimetr2 - stor3) * (perimetr2 - stor4) * (perimetr2 - diagonal));
            Console.WriteLine("Площадь четырехугольника = " + Square);

            Console.WriteLine("задание 2.22");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            int cent1 = rnd.Next(), cent2 = rnd.Next(), cent3 = rnd.Next();
            double sum_pokypki = x * cent1 + y * cent2 + z * cent3;
            Console.WriteLine("Общая стоимость покупки = " + sum_pokypki);

            Console.WriteLine("задание 2.23");
            int N = Convert.ToInt32(Console.ReadLine());
            int mon = rnd.Next(), sis_blok = rnd.Next(), klava = rnd.Next(), mouse = rnd.Next();
            sum_pokypki = N * (mon + sis_blok + klava + mouse);
            Console.WriteLine("Стоимость 3 компьютеров = " + 3 * (mon + sis_blok + klava + mouse));
            Console.WriteLine("Стоимость N копмьютеров = " + sum_pokypki);

            Console.WriteLine("задание 2.24");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            double sr_age = (x + y) / 2;
            double razn1 = Math.Abs(x - sr_age);
            double razn2 = Math.Abs(y - sr_age);
            Console.WriteLine("Средний возраст = {0} \n Разность Тани = {1} \n Разность Мити = {2}", sr_age, razn1, razn2);

            Console.WriteLine("задание 2.25");
            double V_1 = Convert.ToDouble(Console.ReadLine());
            double V_2 = Convert.ToDouble(Console.ReadLine());
            S = Convert.ToDouble(Console.ReadLine());
            double V_convrgence = V_1 + V_2;
            Console.WriteLine("Автомобили встретятся через " + S / V_convrgence + "часов");

            Console.WriteLine("задание 2.26");
            V_1 = Convert.ToDouble(Console.ReadLine());
            V_2 = Convert.ToDouble(Console.ReadLine());
            S = Convert.ToDouble(Console.ReadLine());
            V_convrgence = V_1 - V_2;
            Console.WriteLine("Расстояние между автомобилями будет равно {0}", S + V_convrgence * 0.5);

            Console.WriteLine("задание 2.27");
            double temp = Convert.ToDouble(Console.ReadLine());
            double temp_F = temp * 1.8 + 32;
            double temp_K = temp + 273.15;
            Console.WriteLine("Температура по шкале Фаренгейта = {0} \n Температура по шкале Кельвина = {1}", temp_F, temp_K);

            Console.WriteLine("задание 2.28");
            temp_K = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Температура по шкале Цельсия = " + (temp_K - 273.15));

            Console.WriteLine("задание 3.1");
            double A1 = Convert.ToDouble(Console.ReadLine());
            double B1 = Convert.ToDouble(Console.ReadLine());
            double A2 = A1 + B1;
            double B2 = A2 - B1;
            A2 = A2 - B2;
            Console.WriteLine("Переменная A = {0} \n Переменная B = {1}", A2, B2);

            Console.WriteLine("задание 3.2 (a)");
            a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            a1 = a + b + c;
            b1 = a1 - a - b;
            double c1 = a1 - b - c;
            a1 = a1 - a - c;
            Console.WriteLine("Переменная a = {0} \n Переменная b = {1} \n Переменная с = {2}", a1, b1, c1);

            Console.WriteLine("задание 3.2 (б)");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            a1 = a + b + c;
            b1 = a1 - b - c;
            c1 = a1 - a - c;
            a1 = a1 - a - b;
            Console.WriteLine("Переменная a = {0} \n Переменная b = {1} \n Переменная с = {2}", a1, b1, c1);

            Console.WriteLine("задание 3.3 (а)");
            a = Convert.ToDouble(Console.ReadLine());
            a2 = a * a;
            double a4 = a2 * a2;
            Console.WriteLine("a^4 = " + a4);

            Console.WriteLine("задание 3.3 (б)");
            a = Convert.ToDouble(Console.ReadLine());
            a2 = a * a;
            double a3 = a2 * a;
            double a6 = a3 * a3;
            Console.WriteLine("a^6 = " + a6);

            Console.WriteLine("задание 3.3 (в)");
            a = Convert.ToDouble(Console.ReadLine());
            a2 = a * a;
            a3 = a2 * a;
            a6 = a3 * a3;
            double a7 = a6 * a;
            Console.WriteLine("a^7 = " + a7);

            Console.WriteLine("задание 3.3 (г)");
            a = Convert.ToDouble(Console.ReadLine());
            a2 = a * a;
            a4 = a2 * a2;
            double a8 = a4 * a4;
            Console.WriteLine("a^8 = " + a8);

            Console.WriteLine("задание 3.3 (д)");
            a = Convert.ToDouble(Console.ReadLine());
            a2 = a * a;
            a4 = a2 * a2;
            a8 = a4 * a4;
            double a9 = a8 * a;
            Console.WriteLine("a^9 = " + a9);

            Console.WriteLine("задание 3.3 (е)");
            a = Convert.ToDouble(Console.ReadLine());
            a2 = a * a;
            a4 = a2 * a2;
            a8 = a4 * a4;
            double a10 = a8 * a2;
            Console.WriteLine("a^10 = " + a10);

            Console.WriteLine("задание 3.4(а)");
            a = Convert.ToDouble(Console.ReadLine());
            a2 = a * a;
            a3 = a2 * a;
            double a5 = a2 * a3;
            a10 = a5 * a5;
            Console.WriteLine("a^3 = {0} \n a^10 = {1}", a3, a10);

            Console.WriteLine("задание 3.4(б)");
            a = Convert.ToDouble(Console.ReadLine());
            a2 = a * a;
            a4 = a2 * a2;
            a8 = a4 * a4;
            double a16 = a8 * a8;
            double a20 = a16 * a4;
            Console.WriteLine("a^4 = {0} \n a^20 = {1}", a4, a20);

            Console.WriteLine("задание 3.4(в)");
            a = Convert.ToDouble(Console.ReadLine());
            a2 = a * a;
            a3 = a2 * a;
            a5 = a2 * a3;
            a10 = a5 * a5;
            double a13 = a10 * a3;
            Console.WriteLine("a^5 = {0} \n a^13 = {1}", a5, a13);

            Console.WriteLine("задание 3.4(г)");
            a = Convert.ToDouble(Console.ReadLine());
            a2 = a * a;
            a4 = a2 * a2;
            a5 = a4 * a;
            a10 = a5 * a5;
            double a14 = a10 * a4;
            double a19 = a14 * a5;
            Console.WriteLine("a^5 = {0} \n a^19 = {1}", a5, a19);

            Console.WriteLine("задание 3.4(д)");
            a = Convert.ToDouble(Console.ReadLine());
            a2 = a * a;
            a3 = a2 * a;
            a5 = a3 * a2;
            a10 = a5 * a5;
            double a15 = a10 * a5;
            double a17 = a15 * a2;
            Console.WriteLine("a^2 = {0} \n a^5 = {1} a^17 = {2}", a2, a5, a17);

            Console.WriteLine("задание 3.4(е)");
            a = Convert.ToDouble(Console.ReadLine());
            a2 = a * a;
            a4 = a2 * a2;
            a6 = a2 * a4;
            double a12 = a6 * a6;
            a14 = a12 * a2;
            double a28 = a14 * a14;
            Console.WriteLine("a^4 = {0} \n a^12 = {1} \n a^28 = {2}", a4, a12, a28);

            Console.WriteLine("задание 3.5");
            a = 10;
            a2 = a * a;
            a3 = a2 * a;
            a5 = a2 * a3;
            a10 = a5 * a5;
            Console.WriteLine("10^10 = " + a10);

            Console.ReadKey();





        }






    }
}