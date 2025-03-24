using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0324
{
    internal class @operator
    {
        static void Main(string[] args)
        {
            // 사칙연산자 :: +, -, *, /, %
            // 대입연산자 :: =
            // 복합 대입 연산자 :: +=, -=, *=, /=, %=

            // 문자열 연결 연산자 :: +
            string hello = "안녕";
            string end = "하세요";
            string st = hello + end;    // st = "안녕" + "하세요"

            string a3 = 'a' + 'a' + "a";    
            // 문자 + 문자  => 덧셈 연산 (첫번째 +)
            // 문자 + 문자열 => 연결 연산 (두번째 +)
            Console.WriteLine(a3);

            // 증감 연산자 :: ++, -- (전위 연산, 후위 연산)
            int v = 0;
            Console.WriteLine(v++);     // 값 반환하고, 1 증가
            Console.WriteLine(++v);     // 1 증가하고, 값 반환

            // 비교 연산자 :: <, >, <=, >=, ==(같다), !=(다르다)
            // 논리 연산자 :: &&(and), ||(or), !(not), ^(xor)

            // ^(xor) :: 양 옆의 값이 다르면 true, 같으면 false
            Console.WriteLine(true ^ true);
            Console.WriteLine(false ^ true);

            // 삼항 연산자 ? (조건문과 유사)       -> 2지선다일 때만 활용O
            // 조건식 ? 참일 때 수행 : 거짓일 때 수행;
            int ip = int.Parse(Console.ReadLine());
            Console.WriteLine(ip % 2 == 0 ? "짝!" : "홀...");
        }
    }
}
