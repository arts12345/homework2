
        Console.Write("Введите цифру, обозначающую день недели: ");
        int day1 = Convert.ToInt32(Console.ReadLine());

        void day(int num)
        {
            if (num > 0 && day1 <= 7)
            {
                if (num == 6 || num == 7)
                {
                    Console.WriteLine("Выходной");
                }
                else Console.WriteLine("Не является выходным");
            }
           else Console.WriteLine("Такого дня недели не существует");
        }




        //    Console.WriteLine("Введите цифру, обозначающий день недели: ");
        //    int day = Convert.ToInt32(Console.ReadLine());

        //    bool IsWeekend(int day)
        //    {
        //        if (day > 5) 
        //        {
        //            return true;
        //        }
        //        return false;
        //    }
        //    bool ValidateWeekday (int number)
        //    {
        //        if (number > 0 && number <=7)
        //        {
        //            return true;
        //        }
        //        Console.WriteLine("Это не день недели");
        //        return false;
        //    }

        //    if(ValidateWeekday(day))
        //    {
        //        if(IsWeekend(day))
        //        {
        //            Console.WriteLine("Выходной");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Опять работать");
        //        }
        //    }