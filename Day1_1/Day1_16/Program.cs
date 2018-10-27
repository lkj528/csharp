using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sumtest
{
    static void Main()
    {
        Console.WriteLine(Sum(1, 2));
    }

    static int Sum(params int[] iArray)  // 몇개를 받아도 배열이기때문에 알아서 합 연산을 함.
    {
        int sum=0;

        foreach( int number in iArray)
        {
            sum += number;
        }
        return sum;
    }
    
}
