using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_15
{
    class Program
    {
        static void Main(string[] args)
        {

            String str = Console.ReadLine();

            str.Trim();
            String[] strr = str.Split(',');
            

            int num1, num2;

            try
            {
                num1 = int.Parse(strr[0]);
                num2 = int.Parse(strr[1]);
            }
            catch
            {
                Console.WriteLine("재입력");
                return;
            }
            
            Console.WriteLine("{0} + {1} = {2}", num1, num2, Calc(num1, num2, "+"));
            Console.WriteLine("{0} - {1} = {2}", num1, num2, Calc(num1, num2, "-"));
            Console.WriteLine("{0} * {1} = {2}", num1, num2, Calc(num1, num2, "*"));
            Console.WriteLine("{0} / {1} = {2}", num1, num2, Calc(num1, num2, "/"));





        }

        static double Calc(int num1, int num2, string op)
        {
            double result = 0;
            switch (op)
            {
                case + :
                    op = int.Parse(op);
        



            }
            return result;
        }
    }
}
