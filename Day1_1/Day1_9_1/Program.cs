using System;

namespace Day1_9

{
    class Emp
    {
        public string name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = i;
            Console.WriteLine("i = {0}, j = {1}", i, j);

            Emp e1 = new Emp() { name = "ㅎㄱㄷ" };
            Emp e2 = new Emp() { name = "ㅎㄱㄷ2" };

            e1 = e2;

            Console.WriteLine("e1.name = {0}, e2.name = {1}", e1.name, e2.name);
        }
    }
}