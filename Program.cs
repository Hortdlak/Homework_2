using System;

namespace Homework_2
{
    internal class Program
    {
        static void Main()
        {
            #region Task one - multiples  of 7 and 23.

            //Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

            Multiple_of_two_numbers(7, 23);

            #endregion

            #region Task second - Obtaining the number of the coordinate quarter of the plane.

            //Напишите программу, которая принимает
            //на вход координаты точки(X и Y), причём X ≠ 0 и Y ≠ 0
            //и выдаёт номер координатной четверти плоскости,
            //в которой находится эта точка.

            //Point_in_space ();

            #endregion

            #region Task three - The largest digit of a number from the interval [10, 99].

            //Напишите программу, которая принимает
            //на вход целое число из отрезка[10, 99] и показывает
            //наибольшую цифру числа.

            //The_maximum_number_segment (10, 99);

            #endregion

            #region Task four - Writing a natural number separated by commas.

            //Напишите программу, которая на вход принимает натуральное число N,
            //а на выходе показывает его цифры через запятую.

            //Separated_by_comma ();

            #endregion

            Console.ReadKey ();

        }

        

        private static void Multiple_of_two_numbers (int first_number, int second_number)
        {
            Greetings ($"Проверка числа на кратность одновременно {first_number} и {second_number}");

            int number_check = Getting_number ();

            if ((number_check % first_number == 0) && (number_check % second_number == 0))
            {
                Center_window($"Да, число {number_check} кратно одновременно {first_number} и {second_number}");
            }

            else
            {
                Center_window($"Нет, число {number_check} некратно одновременно {first_number} и {second_number}");
            }
        }

        private static void Point_in_space ()
        {
            Greetings ("Получение номера координатной четверти плоскости");

            int pointX = Getting_number ("координату X");

            int pointY = Getting_number ("координату Y");

            if (pointX > 0)
            {
                if (pointY > 0)
                {
                    Center_window ("1");
                }

                else if (pointY < 0)
                {
                    Center_window ("4");
                }

                return;
            }

            else if (pointX < 0)
            {
                if (pointY > 0)
                {
                    Center_window ("2");
                }

                else if (pointY < 0)
                {
                    Center_window ($"3");
                }

                return;
            }

            else
            {
                Center_window("Нулей у нас быть не может");

                // можно было создать перегрузку метода Getting_number, но фраза понравилась ^_^
            }
        }

        private static void The_maximum_number_segment (int first_number, int second_number)
        {
            Greetings ("Нахождение наибольшей цифры числа из отрезка [10, 99]");

            int number = Getting_number (first_number, second_number);

            int tens = number / 10;
            
            int units = number % 10;

            if (tens > units)
            {
                Center_window ($"{tens}");
            }
            else
            {
                Center_window ($"{units}"); 
            }
        }

        private static void Separated_by_comma ()
        {
            Greetings ("Получение цифр, разделенных запятой.");

            int number = Getting_number ();

            string result = "";

            if (number==0)
            {
                Center_window($"{number}");
            }

            while (number > 0)
            {
                int temp = number % 10;

                result = temp + (result == "" ? "" : ", ") + result;

                number /= 10;
            }

            Center_window (result);

        }

        private static void Greetings(string pattern)
        {
            Center_window(pattern);

            Console.ReadKey();

            Console.Clear();
        }

        static int Getting_number()
        {
            while (true)
            {
                Center_window($"Введите число: ");

                string UserInput = Console.ReadLine(); // запрос числа от пользователя

                Console.Clear();

                if (int.TryParse(UserInput, out int data)) // проверка числа
                {
                    return data; // выход числа из метода
                }
            }
        }

        static int Getting_number(string pattern)
        {
            while (true)
            {
                Center_window($"Введите {pattern}: ");

                string UserInput = Console.ReadLine(); // запрос числа от пользователя

                Console.Clear();

                if (int.TryParse(UserInput, out int data)) // проверка числа
                {
                    return data; // выход числа из метода
                }
            }
        }

        static int Getting_number(int head, int tail)
        {
            while (true)
            {

                Center_window($"Введите двухзначное число: ");

                string UserInput = Console.ReadLine(); // запрос числа от пользователя

                Console.Clear();

                if (int.TryParse(UserInput, out int data))
                {
                    if (head <= data && data <= tail) // проверка на соответствие числа
                    {
                        return data; // выход числа из метода
                    }
                }
            }
        }

        static void Center_window(string pattern)
        {
            int center_x = (Console.WindowWidth / 2) - (pattern.Length / 2);//установка расположения по ширине

            int center_y = (Console.WindowHeight / 2 - 1);// установка расположения по высоте

            Console.SetCursorPosition(center_x, center_y);//установка курсора

            Console.Write(pattern);
        }

    }
}
