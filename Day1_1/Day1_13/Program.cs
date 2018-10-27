using System;
namespace Sub

{
    class sub1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("출력 결과");

            for (int i = 2; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i);

                }

            }
            Console.WriteLine(" ");
            Console.WriteLine("--------------------");
            Console.Write("숫자 입력: ");
            string str1 = Console.ReadLine();
            int m1 = 0;
            bool parsed1 = int.TryParse(str1, out m1);

            if (!parsed1) //예외 
            {
                Console.WriteLine("숫자를 입력");
                Environment.Exit(0);
            }
            Console.Write("{0}까지의 숫자: ", m1);
            for (int j = 0; j < m1 + 1; j++)
            {
                Console.Write("{0},", j);
            }
            Console.Write("\n {0}까지의 합: ", m1);


            int sum = 0;

            for (int j = 0; j < m1 + 1; j++)
            {
                sum += j;

            }
            Console.WriteLine("{0}", sum);

            Console.WriteLine("출력을 원하는 구구단 단수 입력:");

            String str2 = Console.ReadLine();
            int m2 = int.Parse(str2);

            for (int num1 = 2; num1 < 10; num1++)
            {
                int num2 = 1;

                Console.WriteLine(" ");
                for (; num2 < m2 + 1; num2++)
                {
                    Console.Write(" {0} X {1} = {2} ", num2, num1, num1 * num2);

                }

            }
        }
    }
}