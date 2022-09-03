Console.WriteLine("Введите первое число: ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            int m3 = Convert.ToInt32(Console.ReadLine());
            if (m1 > m2)
                if (m1 >m3)
            {
                Console.WriteLine(m1);
            }
            if (m2 > m1)
                if (m2 >m3)
            {
                Console.WriteLine(m2);
            }
            else
            {
                Console.WriteLine(m3);
            }
