using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0324
{
    internal class Ex_calc
    {
        static void Main(string[] args)
        {
            // "정수형" 2개를 입력받고
            // 입력 [1] :: 개행으로 구분하며 입력받기
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            // 입력 [2] :: 공백으로 구분하며 입력받기     -> Split() 활용
            var input = Console.ReadLine().Split();     // input[0]'5' input[1]'8'
            int n1 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);

            // 5가지의 사칙연산 결과를 순차 출력 (+, -, *, /, %)
            Console.WriteLine();
            Console.WriteLine(n1 + n2);
            Console.WriteLine(n1 - n2);
            Console.WriteLine(n1 * n2);
            Console.WriteLine(n1 / n2);
            Console.WriteLine(n1 % n2);
        }
    }
}
