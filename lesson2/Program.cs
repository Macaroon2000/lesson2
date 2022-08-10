using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Крылов Роман
namespace lesson2Krylov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Написать метод, возвращающий минимальное из трёх чисел.

            Console.WriteLine("Определение минимального из трех целых чисел");
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int min = 0;

            if (a <= b && a <= c)
            {
                min = a;
            }
            else if (b <= c)
            {
                min = b;
            }
            else
            {
                min = c;
            }

            Console.WriteLine("Наименьшее число {0}", min);

            Console.WriteLine("");
            Console.ReadKey();
            //2. Написать метод подсчета количества цифр




            Console.Write("Введите целое число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (n != 0)
            {
                n = n / 10;
                count++;
            }
            Console.WriteLine("Количество цифр в числе:  {0}", count);

            Console.ReadKey();
            /*3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.*/
            {
                Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
                int i, sum = 0;
                Console.WriteLine("Введите числа, нажимая после каждого Enter.");
                do
                {
                    i = int.Parse(Console.ReadLine());
                    if ((i % 2 == 1) && (i > 0)) sum += i;
                } while (i != 0);
                Console.WriteLine("Результат: {0}\n---", sum);
                //4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
                //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
                //Используя метод проверки логина и пароля, написать программу:
                //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
                //С помощью цикла do while ограничить ввод пароля тремя попытками.


                Console.WriteLine("Проверка логина и пароля");
                int AmountOfTries = 3;

                do
                {
                    Console.Write("Введите логин: ");
                    string login = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    string password = Console.ReadLine();

                    if (login == "root" && password == "GeekBrains")
                    {
                        Console.WriteLine("Авторизация успешна!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод логина или пароля." +
                        Environment.NewLine + "У Вас осталось попыток: " + --AmountOfTries);
                    }

                } while (AmountOfTries > 0);


                Console.WriteLine("");
                Console.ReadKey();
                #region Task5

                Console.Clear();

                Console.WriteLine("Подсчет индекса массы тела (расширенная)");
                Console.WriteLine("========================================\n");

                Console.Write("Укажите ваш рост (см): ");
                var heightInput = Console.ReadLine();
                var height = Convert.ToDecimal(heightInput) / 100; // CM -> метры 
                Console.Write("Укажите ваш вес (кг): ");
                var weightInput = Console.ReadLine();
                var weight = Convert.ToDecimal(weightInput);
                var index = weight / (height * height);
                Console.WriteLine($"ИМТ: {index:F2}");

                if (index <= 16)
                    Console.WriteLine($"У вас выраженный дефицит массы тела.");
                else if (index > 16 && index <= (decimal)18.5)
                    Console.WriteLine($"У вас недостаточная (дефицит) масса тела.");
                else if (index > (decimal)18.5 && index <= 25)
                    Console.WriteLine($"У вас нормальное телосложение.");
                else if (index > 25 && index <= 30)
                    Console.WriteLine($"У вас избыточная масса тела (предожирение).");
                else if (index > 30 && index <= 35)
                    Console.WriteLine($"У вас ожирение.");
                else if (index > 35 && index <= 40)
                    Console.WriteLine($"У вас резкое ожирение.");
                else
                    Console.WriteLine($"У вас очень резкое ожирение.");

                if (index < 20 || index > 25)
                {
                    var addIndex = index < (decimal)20 ? index - (decimal)20 : index - 25;
                    var addWeight = addIndex * height * height;
                    Console.WriteLine("Вам необходимо {0} {1:F2} кг для нормализации веса.", addIndex > 0 ? "сбросить" : "набрать", Math.Abs(addWeight));
                }

                Console.ReadKey();

                #endregion
                Console.WriteLine("Подсчет количества \"хороших\" чисел");
                Console.WriteLine("==================================\n");
                Console.WriteLine($"Производится подсчет количества хороших чисел.\nЭто может занять несколько минут ...");
                DateTime start = DateTime.Now;
                count = 0;
                sum = 0;

                var maxNumber = 1_000_000_000;

                for (int I = 1; I <= maxNumber; I++)
                {
                    if (I % GetSum(I) == 0)
                    {
                        count++;
                        sum += I;
                    }
                }
                DateTime finish = DateTime.Now;
                Console.WriteLine($"Количество хороших чисел в диапазоне от 1 до {maxNumber} равно {count}, сумма: {sum}");
                Console.WriteLine($"Подсчет занял у нас {finish - start}");
                Console.ReadKey();

                

                 int GetSum(int number) // Пусть на вход мы получили 15
                {
                    sum = 0;   /// Сумма цифр числа, изначально 0
                    while (number > 0)  // число > 0 ?
                    {
                        sum += number % 10; // Делим число (например 15) на 10 и берем остаток от деления, какой будет остаток? 15/10 ? остаток будет равен 5 , именно его, остаток мы складываем в сумму (sum)
                        number /= 10; // Целую часть от деления 15 на 10 ( это будет .... 1) мы складываем в number
                    }
                    return sum; // Таким образом за 2 итерации мы наше число 15 разбиваем на подчисла 5 и 1 , складываем их и получаем .... 6.
                }
            }
        }
    }
}

