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

        //Функция акермана
        static int GetAcerman(int m, int n)
        {
            if (m == 0)
                return n + 1;
            else if (n == 0)
                return GetAcerman(m - 1, 1);
            return GetAcerman(m - 1, GetAcerman(m, n - 1));
        }

  static void Main (string[] args)
        {
            //Рекурсивный ввод числа n
            var n = GetDigit("первое число");
            //Рекурсивный ввод числа n
            var m = GetDigit("второе число");

            Console.WriteLine("Функция Акерамана для параметров {0},{1} = {2}", n, m, GetAcerman(n, m));
  }