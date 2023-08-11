Console.WriteLine("введите число: ");
        int number =Convert.ToInt32(Console.ReadLine());

       void SecondRange(int num)
        {
            if (num >= 100 && num <= 999)
            {
                Console.WriteLine(num%100/10);
            }
            else Console.WriteLine("Число должно быть трёхзначным");
        }
        SecondRange(number);