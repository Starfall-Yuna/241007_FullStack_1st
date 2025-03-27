using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0327
{
    internal class ref_out
    {
        // swap() 함수 구현 ::
        static void swap(ref int n1, ref int n2)    // 매개변수 값, 메모리 공간을 함께 받아옴
        {
            // swap 기초 원리
            int tmp = n1;
            n1 = n2;
            n2 = tmp;
        }
        static void add(out int sum, int a, int b)  // int sum :: 매개변수 값만 가져오기
        {
            // ref 키워드처럼, sum-result 연결되는 건 같음
            // out int sum -> add() 메소드 안에서, sum의 값을 새로 설정(문법 상 필수)
            sum = a + b;
        }

        static void Main(string[] args)
        {
            // ref :: "참조자", 값과 메모리 정보를 함께 전달할 때 사용
            // 값과 메모리 공간을, "전달받는 쪽에도 전달하는 쪽에도" ref 키워드 명시
            // 배열 원소에 대한 사용은 지원X

            int[] number = { 100, 0 };
            // number[1] = number[0];      // 값만 전달(call by value) -> 두 공간은 독립적
            // ref int n1 = ref number[0];     // number[0]의 값+메모리 주소값을 n1에서 전달받음
            // n1 = int.Parse(Console.ReadLine());  

            swap(ref number[0], ref number[1]);      
            Console.WriteLine(number[0] + " " + number[1]);

            // out :: ref와 동일한 기능 + 
            int result = 0;
            add(out result, number[0], number[1]);
            Console.WriteLine("덧셈 결과: " + result);
        }
    }
}
