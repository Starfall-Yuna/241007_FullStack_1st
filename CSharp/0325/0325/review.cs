using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0325
{
    internal class review
    {
        static void Main(string[] args)
        {
            // 출력문 :: Write(), WriteLine()      => cw + Tab 1-2번
            // 입력문 :: ReadLine()        => 입력값을 string 형태로 받음
            //      => int.Parse()나 double.Parse()로 파싱 필요
            //      => 공백을 기준으로 값을 나누어 입력 -> Split() 활용
            Console.WriteLine("Hello World!!!");
            var input = Console.ReadLine().Split();     // input -> string[] 타입
            int h = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            Console.WriteLine($"현재 시각은 {h}시 {m}분입니다.");
            Console.WriteLine();

            // 자료형 :: 정보의 종류
            // int, long, float, double, char, string, bool, ...
            // var => 초기값에 따라서, 자료형이 자동 결정
            // float값을 설정할 땐, 값 뒤쪽으로 F를 적어줘야함
            var pi = 3.14F;
            Console.WriteLine(pi);
            Console.WriteLine(pi.GetType());

            // 연산자 :: 이전 프로젝트 참고
            // ^(xor)   -> 두 비교값이 서로 다르면 true, 같으면 false
        }
    }
}
