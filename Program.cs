using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Task1
            /* 1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
               В результате вся информация выводится в одну строчку.
            а) используя склеивание;
            б) используя форматированный вывод;
            в) *используя вывод со знаком $.
            Выполнил Альберт Баранов 
            */



            Console.Title = "Albert Baranov home work to the lesson 01";
            Console.Clear();

            //Ввод данных: имя, фамилия, возраст, рост, вес

            Console.Write("Имя: ");
            var name = Convert.ToString(Console.ReadLine());
            Console.Write("Фамилия: ");
            var coname = Convert.ToString(Console.ReadLine());
            Console.Write("Возраст: ");
            var age = Convert.ToString(Console.ReadLine());
            Console.Write("Рост: ");
            var high = Convert.ToString(Console.ReadLine());
            Console.Write("Вес: ");
            var weight = Convert.ToString(Console.ReadLine());
            Console.WriteLine(name + " " + coname + " " + age + " " + high + " " + weight); // а) Вывод на экран с помощью склеивания
            Console.ReadKey();              

            Console.WriteLine("{0} {1} {2} {3} {4}", name, coname, age, high, weight); // б) Вывод на экран используя форматирование
            Console.ReadKey();

            Console.WriteLine($"{name} {coname} {age} {high} {weight}"); // в) Вывод на экран используя интерполяцию
            Console.ReadKey();

            #endregion


            #region Task2
            /* 2. Ввести вес и рост человека. 
             Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах 
             Выполнил Альберт Баранов
            */

            Console.Clear();


            

            Console.Write("Вес (в кг)"); //Ввод роста и веса
            var weight1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Рост  (в метрах, например 1,78 если рост человека 178 см)");
            var high1 = Convert.ToDouble(Console.ReadLine());        
            var res1 = weight1 / (high1 * high1); //формула расчета индекса массы тела (ИМТ)
            Console.WriteLine($"Индекс массы тела (ИМТ) = {res1}");
            Console.ReadKey();


            #endregion

            #region Task3
            /* а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
             * по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f 
             * с двумя знаками после запятой);
               б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
               Выполнил Альберт Баранов
            */

            Console.Clear();

            // Ввод координат x1, y1 и x2, y2

            Console.Write("Координата X1 = ");
            var x1 = double.Parse(Console.ReadLine());
            Console.Write("Координата Y1 = ");
            var y1 = double.Parse(Console.ReadLine());
            Console.Write("Координата X2 = ");
            var x2 = double.Parse(Console.ReadLine());
            Console.Write("Координата Y2 = ");
            var y2 = double.Parse(Console.ReadLine());

            

            var r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // Формула для вычисления расстояния между точками с координатами (x1;y1) и (x2;y2)
            Console.WriteLine("Pасстояние между точками c координатами (x1;y1) и (x2;y2) = {0:F}", r); // Ответ выводится в формате, содержащим 2 знака после запятой
            Console.ReadKey();


            // Задание б* Вычисление расстояния между координатами в виде метода

            Console.WriteLine("Расстояние между точками c координатами (x1;y1) и (x2;y2) = {0:F}", Rasst(x1, y1, x2, y2));
            Console.ReadKey();

            #endregion

            #region Task4
            /* 4. Написать программу обмена значениями двух переменных.
            а) с использованием третьей переменной;
            выполнил Альберт Баранов*/

            Console.Clear();
            Console.Write("Переменная a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Переменная b = ");
            var b = double.Parse(Console.ReadLine());
            

            var c = a;
            a = b;
            Console.WriteLine($"В результате обмена a = {b}");
            Console.WriteLine($"В результате обмена b = {c}");
            Console.ReadKey();

            /* 4. Написать программу обмена значениями двух переменных.
            б*) без использования третьей переменной;
            выполнил Альберт Баранов*/

            Console.Clear();
            Console.Write("Переменная a = ");
            var a1 = double.Parse(Console.ReadLine());
            Console.Write("Переменная b = ");
            var b1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"В результате обмена a = {(a1 + b1) - a1}");
            Console.WriteLine($"В результате обмена b = {(a1 + b1) - b1}");
            Console.ReadKey();

            #endregion


            #region Task5

            /*Задание 5 
             * а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
             выполнил Альберт Баранов
            */

            Console.Clear();
            string name1 = "Альберт Баранов г. Новочебоксарск";
            Console.WriteLine($"{name1}");
            Console.ReadKey();

            /*Задание 5
             * б) выводит в  центр экрана имя, фамилию и город проживания.
            */

            Console.Clear();
            int x = 45;
            int y = 14;
            Console.SetCursorPosition(x, y);
            Console.WriteLine($"{ name1}");
            Console.ReadKey();


            /*Задание 5
             * в) *Сделать задание б с использованием собственных методов (например, Print(string msg, int x,int y)
            */

            Console.Clear();
            Print(name1, x, y);// вызов метода Print который печатает символьную переменную начиная с позиции c координатами (x , y)
            Print(name1, ConsoleColor.Green);//вызов метода Print который печатает символьную переменную цветом Green
            Console.ReadKey();

            #endregion

            #region Task6

            /**Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
             * Не разобрался до конца Альберт Баранов
            */
            #endregion


















        }
        static double Rasst(double x1, double y1, double x2, double y2)// метод для вычисления расстояния между точками с координатами (x1;y1) и (x2;y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));//расчетная формула
        }
    class Printhelp
    {

            static void Print(string msg, int x, int y)// метод печатает символьную переменную начиная с позиции c координатами (x , y)
            {
                Console.SetCursorPosition(x, y);// Установка позиции курсора на экране
                Console.WriteLine(msg);// Вывод символьной переменной
            }

            static void Print(string msg, ConsoleColor foregroundcolor)// метод для печати символьной переменной заданным цветом
            {
                Console.ForegroundColor = foregroundcolor;// Установка цвета символов
                Console.WriteLine(msg);// Вывод символьной переменной
            }





















    }












    }
















}








