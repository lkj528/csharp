using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_3
{
    class Program
    {

        string a = "9";
        
        static void Main(string[] args) // (string[] args) = main이 시작될때 던져줄 값.(배열)
        {
            string s = args[0]; // 솔루션 탐색기에서 Properties 클릭해서 디버그에서 명령줄 인수에 숫자 입력 (시작 프로젝트 지정 해야함)
            int number = int.Parse(s);

            for(int i=0; i<=number; i+=2)
            {
                Console.WriteLine(i);
            }



        }
    }
}
