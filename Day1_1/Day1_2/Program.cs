using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{



     
        class MyConstants
        {
            public const double PI = 3.14;  // const = 상수  PI와 MYAGE는 클래스의 멤버(필드). const는 static 효과 (static이 붙으면 객체 생성 없이 참조 가능)

            public const int MYAGE = 22;

        }

        class Program
        {
            static void Main(string[] args)
            {
                double radius = 2;
                double area = MyConstants.PI * (radius * radius);
                Console.WriteLine("Area = {0}, Age={1}", area, MyConstants.MYAGE);

                const string name = "홍길동";
                Console.WriteLine("name: " + name);


            }
        }
    }





/*namespace Day1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 9;
            var ii = 9;
            var jj = "Hello"; // var는 컴파일러가 알아서 자료형 지정
            int j;
            j = 9;
        }
    }
}*/
