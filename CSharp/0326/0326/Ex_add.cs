using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0326
{
    internal class Ex_add
    {
        // add_all() 함수 구현
        //  - 배열을 통째로 매개변수로 받아오고
        //  - 배열의 값을 모두 더한 결과를 반환 (이때 반환 형태를 double형으로)
        static double add_all(int[] target)
        {
            int result = 0;     // 덧셈 결과 저장할 변수
            foreach(var item in target)     // item을 통해서, target의 요소 하나씩 접근
            {
                result += item;
            }
            return result;      // 함수 종료와 동시에, result 결과 반환
        }
        static void Main(string[] args)
        {
            // int형 배열(number)의 크기를 5로 설정
            int[] number = new int[5];

            // 5개의 정수형 값을 입력받고, 이를 number에 저장
            for (int i = 0; i < 5; i++) 
            {
                int n = int.Parse(Console.ReadLine());
                number[i] = n;
            }

            // number에 대한 add_all()의 결과값을 Main에서 출력
            double add_result = add_all(number);    // 함수 실행값이 add_result 저장
            Console.WriteLine("덧셈 결과: " + add_result);
            Console.WriteLine("add_all() 반환형: " + add_all(number).GetType()); 

        }
    }
}
