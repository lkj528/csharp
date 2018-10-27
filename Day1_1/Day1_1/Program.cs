using System;

class TypeCastExample1
{
    public static void Main()
    {





        short a = 10;
        int b = a;
        int c = 50000;
        try
        {
            short d = checked((short)c);
            Console.WriteLine("Short : {0}", d);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.StackTrace);
        }
    }
}





/*using System; // System = 분류 이름






namespace Day1_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello C#~"); // console: system 안에 있는 class
                                            //using System을 안쓰면 System.Console.WriteLine으로 써야 함.


            int i = 10;
        }
    }
}
*/