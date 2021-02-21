using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            //Task10();
            //Task11();
            //Task12(5);
            //Task16(476);
            //Task17();
            //Task19();
            Task24(4,5 ,65,3);
            //Part1();
            //rate();
        }
        public static void Task1()
        {
            Console.Write(5);
            Console.Write(" ");
            Console.Write(" ");
            Console.Write(5);
            Console.Write(" ");
            Console.Write(" ");
            Console.Write(3);
            Console.WriteLine();
        }

        public static void Task2()
        {
            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);
        }

        public static void Task3()
        {
            const int meter = 100;
            Console.Write("Расстояние в сантиметрах: ");
            string distance = Console.ReadLine();
            double b;
            bool result = double.TryParse(distance, out b);
            if (result)
            {
                double value = b / meter;
                Console.WriteLine("Результат = " + value + "(метр)");
            }
            else
            {
                Console.WriteLine("Вы ввели не целое число.(((");
            }        

        }

        public static void Task4()
        {
            int days = 234;
            int weeks = days / 7;
            Console.WriteLine("количество недель в 234 днях = " +weeks + " недели");
        }

        public static void Task5()
        {
            string number = Console.ReadLine();
            int a = Convert.ToInt32(number);
            int b = 0;
            int c = 0;
            int sum = 0;
            if (a >= 10 || a <= 99)
            {
                b = a / 10;
                c = a % 10;
                sum = b + c;
                Console.WriteLine("Количество десятков в числе = " + b);
                Console.WriteLine("Сумма цифр в двузначном числе = " + sum);
            }
        }

        public static void Task6()
        {
            bool A = true;
            bool B = false;
            bool C = false;
            if (A || B)
            {
                Console.WriteLine(true);
            }
            if (A && B)
            {
                Console.WriteLine(false);
            }
            if (B || C)
            {
                Console.WriteLine(false);
            }
        }

        public static void Task7()
        {
            const double PI = 3.14159;
            int Radius = 6;
            int Side = 12;
            var CircleArea = Radius * PI * PI;
            var SquareArea = Side* Side;
            Console.WriteLine("Площадь круга = "+ CircleArea);
            Console.WriteLine("Площадь квадрата = "+ SquareArea);
            if (CircleArea > SquareArea)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Площадь круга больше площади Квадрата");                
            }
            else if (CircleArea == SquareArea)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Площадь круга равна площади Квадрата");                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Площадь круга меньше площади Квадрата");
            }
            

        }

        public static void Task8()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if (int.Parse(a) > int.Parse(b))
            {
                Console.WriteLine("Значение " +a +" больше "+b);
            }
            else if (int.Parse(a) == int.Parse(b))
            {

            }
            
            else
            {
                Console.WriteLine("Значение " + a + " меньше " + b);
            }
        }

        public static void Task9()
        {
            
            Console.Write("Введите напряжение первой цепи U = ");
            int U1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сопротивление первой цепи R = ");
            int R1 = Convert.ToInt32(Console.ReadLine());
            double I1 = U1 / R1;
            Console.Write("Введите напряжение второй цепи U = ");
            int U2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сопротивление второй цепи R = ");
            int R2 = Convert.ToInt32(Console.ReadLine());
            double I2 = U2 / R2;
            if (I1 > I2)
            {
                Console.WriteLine("Во второй цепи меньше тока");
            }
            else
            {
                Console.WriteLine("В первой цепи меньше тока");
            }



        }

        public static void Task10()
        {
            int numbers = 20;
            Console.WriteLine("Task a: ");
            for (int i = 0; i <= 15; ++i)
            {
                Console.WriteLine(numbers);
                numbers++;
            }
            Console.WriteLine("Task b: ");
            Console.Write("Введите число b (b > 10) = ");
            b: int b = Convert.ToInt32(Console.ReadLine());
            double stepen = 2.0;
            var value = 10;
            if (b < 10)
            {
                Console.WriteLine("Значение должно быть больше 10.");
                Console.WriteLine("Введите ещё раз.");goto b;
            }
            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine("Квадрат числа " + i + " = "+ Math.Pow(value, stepen));
                value++;
            }
            Console.WriteLine("Task c: ");
            Console.Write("Введите число a (a < 50) = ");
            a: int a = Convert.ToInt32(Console.ReadLine());
            if (a > 50)
            {
                Console.Write("Число должно быть меньше 50. Повторите ввод: ");goto a;
            }
            int count = a;
            while (count <= 50)
            {
                Console.WriteLine("Третья степень числа " + count + " = " + Math.Pow(count, 3));
                count++;
            }
            Console.WriteLine("Task c: ");
            if (b < a)
            {
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
            }
            else
            {
                while (a <= b)
                {
                    Console.WriteLine(a);
                    a++;
                }
            }
        }

        public static void Task11()
        {
            //y=7𝑥^2−3𝑥+4
            double x = 0.0;
            
            Console.Write("Введите значение x = ");
            x = Convert.ToDouble(Console.ReadLine());

            var y = 7 * (x * x) - 3 * x + 4;
            Console.WriteLine("y = "+y);
        }

        public static void Task12(int radius)
        {
            double PI = 3.14159;
            var l = 2 * PI * radius;
            var S = PI * radius;
            Console.WriteLine("Длина окружности = "+l);
            Console.WriteLine("Площадь круга = "+S);

        }

        public static void Task16(int number)
        {
            int a = number / 100;
            int b = number % 100;
            int c = b / 10;
            int d = b % 10;
            int sum = a + c + d;
            int proizvedenie = a * c * d;
            Console.WriteLine("Сумма всех цифр числа = " +sum);
            Console.WriteLine("Произведение цифр = " + proizvedenie);
        }

        public static void Task17()
        {
            string num = "465";
            char[] array = num.ToCharArray();
            char[] newArray = new char[1];
            for (int i = 0; i <array.Length; i++)
            {
                if (i == 1)
                {
                    newArray[0] = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = newArray[0];
                }
            }
            Console.WriteLine(array);

 
            

            
                    
        }

        public static void Task19()
        {
            unsafe
            {
                int numberA = 55;
                int numberB = 111;
                int* temp;
                int* a = &numberA;
                int* b = &numberB;
                Console.WriteLine("a = " + *a);
                Console.WriteLine("b = " + *b);
                Console.WriteLine();
                temp = a;             
                a = b;
                b = temp;
                Console.WriteLine("a = " + *a);
                Console.WriteLine("b = " + *b);



            }
        }

        private static void rate()
        {
            /*Напишите программу, 
             * которая с помощью 
             * функции rand() ставит оценки в пределах от 2 до 5.
             * В файл протокола направляйте слово “Неуд” при появлении 2, 
             * «Удовл» при появлении 3, и т.д. Используйте оператор switch.*/
            List<int> students = getList(2, 5, 1, 15);
            int k = 1;
            //foreach (var item in students)
            //{
            //    setColor(item);
            //    Console.WriteLine("Student #"+k+++ ":" +item);
            //}

            //k = students.Count - 1;
            //while (k != 0)
            //{
            //    setColor(students[k--]);
            //    Console.ForegroundColor = ConsoleColor.White;
            //}

            while (true)
            {
                setColor(students[k++]);
                Console.ForegroundColor = ConsoleColor.White;
                if (students.Count > k)
                {
                    break;
                }
            }

        }

        private static void setColor(int rate)
        {
            switch (rate)
            {
                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("A");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("B");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("C");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("D");
                    break;
                default:
                    break;
            }
        }


        public static void forMinValue()
        {
            var numbers = getList();
            showList(numbers);
            int min = numbers[0];
            foreach (int item in numbers)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine("Minimal value: " + min);
        }

        private static void showList(List<int> number)
        {
            int counter = 0;
            foreach (var item in number)
            {
                Console.Write(item + " ");
                if (counter == 10)
                {
                    Console.WriteLine("");
                    counter = 0;
                }
                else
                    counter++;
            }
        }
        private static List<int> getList(int numberFrom = 1, int numbersTo = 1000, int callFrom = 1, int callTo = 1000)
        {
            List<int> numbers = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(1, 1000); i++)
            {
                numbers.Add(rnd.Next(numberFrom, numbersTo));
            }
            return numbers;

        }
        public static double date(int hours = 0, int minutes = 0, int seconds = 0)
        {
            /*Напишите функцию int f(int h, int m, int s), которая принимает три целых аргумента 
             * (часы h, минуты m и секунды s) и возвращает количество секунд, прошедших с начала дня.*/
            DateTime currTime = DateTime.Now;
            DateTime date = new DateTime(currTime.Year, currTime.Month, currTime.Day, hours, minutes, seconds);
            return (currTime - date).TotalSeconds;

        }




        public static int Task24(int a = 0, int b = 0, int x = 0, int y = 0)
        {
            /*Напишите функцию int f(int& a, int& b, int x, int y), 
            которая присваивает объекту a значение, равное x*y, а объекту b значение x/y. Если значение y*/
            a = x * y;
            b = x / y;
            if (a == 0 || b == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("error");
            }
            else if (a < 0 || b < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("A equals:" + a);
                Console.WriteLine("B equals:" + b);
            }
            return 0;
        }

        public static void Lesson1()
        {
            int x = 0;
            int y = new int();
            string str = "";
            char d = str[0];

            //неявная типизация
            var z = 25;

            Console.WriteLine("hello");

            //явное преобразование
            object o = 55;

            //1.
            int n = Convert.ToInt32(o);
            int i = Int32.Parse(o.ToString());
        }
    }
}
