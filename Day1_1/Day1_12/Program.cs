﻿using System;
namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("숫자 입력");
            string str = Console.ReadLine();
            int m = 0;
            bool parsed = int.TryParse(str, out m);




            if (!parsed)
            {
                Console.WriteLine("숫자를 입력");
                Environment.Exit(0);
            }



            int i = 0;
            int sum = 0;
            while (i <= m)
            {
                if (i % 2 == 0) sum += i;
                i++;
            }
            Console.WriteLine("1부터 {0}까지의 짝수 합: {1}", m, sum);


            i = 0;
            sum = 0;
            do
            {
                if (i % 2 == 0) sum += i;
                i++;

            }
            while (i <= m);
            Console.WriteLine("1부터 {0}까지의 짝수 합{1}", m, sum);

            sum = 0;
            for (i = 0; i <= m; i++)
            {

                if (i % 2 == 0) sum += i;
                Console.WriteLine("1부터 {0}까지의 짝수 합{1}", m, sum);
            }

        }
        
    }
}