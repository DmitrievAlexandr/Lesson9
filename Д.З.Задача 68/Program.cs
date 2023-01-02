
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

        
        int GetAcerman(int m, int n)
        {
            if (m == 0)
                return n + 1;
            else if (n == 0)
                return GetAcerman(m - 1, 1);
            return GetAcerman(m - 1, GetAcerman(m, n - 1));
        }

            
            var n = GetDigit("первое число");
            
            var m = GetDigit("второе число");

            Console.WriteLine("Функция Акерамана для параметров {0},{1} = {2}", n, m, GetAcerman(n, m));