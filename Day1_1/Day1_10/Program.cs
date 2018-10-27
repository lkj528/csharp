﻿using System;
namespace day1

{
    enum Day1
    {
        Monday, Thesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    enum Day2: byte
    {
        Monday = 11, Thesday, Wednesday, Thursday, Friday, Saturday, Sunday = Monday +100
    }

    public class EnumTest
    {
        static void Main()
        {
            Day1 whatDay = Day1.Sunday;
            Console.WriteLine("{0}", whatDay);
            Console.WriteLine("{0}", (int)whatDay);

            whatDay = (Day1)6;
            Console.WriteLine("{0}", whatDay);

            Day2 whatDay2 = Day2.Monday;
            Console.WriteLine("{0}", whatDay2);
            Console.WriteLine("{0}", (int)whatDay2);

            whatDay2 = (Day2)111;
            Console.WriteLine("{0}", whatDay2);


        }
    }
}