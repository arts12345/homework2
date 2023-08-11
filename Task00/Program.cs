 Console.WriteLine("введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        bool ValidateNumb( int num)
        {
            if (num > 100)
            {
                return true;
            }
            return false;
        }

        int num999 ( int number)
        {
            while (number > 999) 
            {
                number /= 10;
            }
            return number % 10;
        }

        if (ValidateNumb(num))
        {
            Console.WriteLine(num999(num));
        }