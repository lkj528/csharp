using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sum = 0;

            for(int i=0; i<myArray.Length;i++)
            {
                sum += myArray[i];
            }

            Console.WriteLine("배열의 합은 {0}", sum);

            sum = 0;
            
            foreach( int number in myArray)
            {
                sum += number;
            }
            Console.Write("배열의 합2는 {0} " , sum);
        }
    }
}
