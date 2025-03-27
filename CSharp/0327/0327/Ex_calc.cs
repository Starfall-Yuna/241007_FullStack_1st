using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _0327
{
    internal class Ex_calc
    {
        // * plus() 함수 구현
        // - 반환형 void, 매개변수 2개(result, add)
        // - result+add 결과값을, result와 연결된 변수에 전달 (ref/out 중 하나)
        static void plus(ref int result, int add)
        {
            // out :: plus() 함수 내에서, result를 새로 정의하지 않으면 활용X
            //      "out 변수에 대해선, 함수 내에서 새로 값 설정하고 활용"
            result += add;
            // result = result + add;
            Console.WriteLine("plus() result 값 : " + result);
        }

        // * minus() 함수 구현
        // - 반환형 void, 매개변수 2개(result, sub)
        // - result-sub 결과값을, result와 연결된 변수에 전달
        static void minus(ref int result, int sub)
        {
            result -= sub;
            // result = result - sub;
            Console.WriteLine("minus() result 값 : " + result);
        }
        
        static void Main(string[] args)
        {
            // * Main 함수
            // 계좌에 있는 돈(money)을 10000으로 초기화하기
            int money = 10000;

            // 문자 하나('+', '-' 중 하나)와 특정 금액을 입력받기
            char oper = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            // +인 경우, plus()를 통해 특정 금액(n)을 money에 추가하기
            if (oper == '+')
            {
                plus(ref money, n);
            }
            // -인 경우, minus()를 통해 특정 금액(n)을 money에서 빼기
            else
            {
                minus(ref money, n);
            }

            // 추가 / 뺀 결과를 출력한 뒤 실행 종료
            Console.WriteLine("현재 money : " + money);
        }
    }
}
