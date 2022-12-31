// Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.

/// <summary>
        /// Рекурсивный запрос числа в консоли
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        static int GetDigit(string comment)
        {
            Console.WriteLine($"Введите {comment}:");
            //Ввод пользователя
            var d = Console.ReadLine();
            try
            {
                //Попытка получить число из введенной строки
                var digit = Convert.ToInt32(d);
                return digit;
            }
            catch (Exception)
            {
                //Это не число, снова просим повторить ввод
                Console.WriteLine($"Ошибка, введенное значение {d} не является числом!");
                return GetDigit(comment);
            }
        }

        //Сумма чисел в интервале от n до m
        static int GetSumm(int n, int m)
        {
            int min = 0, max = 0;
            //Числа равны - нечего считать
            if (n == m)
                return n + m;

            if (n > m)
            {
                //Пользователь ошибся
                min = m;
                max = n;
            }
            else
            {
                min = n;
                max = m;
            }

            return Summ(min, max);
        }

        //Рекурсия - расчет суммы между чисел
        static int Summ(int current, int max, int summ = 0)
        {
            if (current > max)
            {
                return summ;
            }
            summ = summ + current;
            current++;
            return Summ(current, max, summ);
        }

        static void Main(string[] args)
        {
            //Рекурсивный ввод числа n
            var n = GetDigit("первое число");
            //Рекурсивный ввод числа n
            var m = GetDigit("второе число");

            Console.WriteLine("Сумма натуральных чисел в интервале от {0} до {1} = {2}", n, m, GetSumm(n, m));
  }