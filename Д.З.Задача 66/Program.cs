

        int GetDigit(string comment)
        {
            Console.WriteLine($"Введите {comment}:");
            
            var d = Console.ReadLine();
            try
            {
                
                var digit = Convert.ToInt32(d);
                return digit;
            }
            catch (Exception)
            {
                
                Console.WriteLine($"Ошибка, введенное значение {d} не является числом!");
                return GetDigit(comment);
            }
        }

        
        int GetSumm(int n, int m)
        {
            int min = 0, max = 0;
            
            if (n == m)
                return n + m;

            if (n > m)
            {
                
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

        
        int Summ(int current, int max, int summ = 0)
        {
            if (current > max)
            {
                return summ;
            }
            summ = summ + current;
            current++;
            return Summ(current, max, summ);
        }

            
            var n = GetDigit("первое число");
            
            var m = GetDigit("второе число");

            Console.WriteLine("Сумма натуральных чисел в интервале от {0} до {1} = {2}", n, m, GetSumm(n, m));