using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_5
{

    class Emp
    {
        public static string name;  // 여기서 스테틱 안붙이면 바로 접근 할 수 없기 때문에
        public static void GoToOffice()
        {
            System.Console.WriteLine(name + " 이 출근");
        }
    }
    class EmpTest



    {
        static void Main()
        {

            //Emp e = new Emp();  이렇게 객체 참조 변수를 선언해줘야 함.
            Emp.name = "김";
            System.Console.WriteLine(Emp.name);
            Emp.GoToOffice();

            
        }
    }
}

