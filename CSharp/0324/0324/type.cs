using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _0324
{
    internal class type
    {
        static void Main(string[] args)
        {
            // 자료형 :: 정보의 종류
            // (정수형) int, long
            // (실수형) float, double
            // (문자형) char, string
            // (진위형) bool
            // (자료형 자동 배정) var      -> 자료형X
            
            // 활용을 안하고 있는 변수의 경우엔, 초록색 밑줄이 그어질 수 있음
            int i = 6;
            double d = 3.1415;
            char c = 'a';
            char hangul = '갉';      // 한글을 하나의 문자로 저장O (C#에선 유니코드 함께 지원)
            string st = "문자열";
            bool tf = true;
            var v = 3.33333F;      // 초기값 없으면, 자료형 배정X -> 에러 발생
            // 기본 실수형 타입은 double형

            Console.WriteLine(v);
            Console.WriteLine();

            // getType() 통해서, 자료형 반환받을 수 있음
            Console.WriteLine(i.GetType());
            Console.WriteLine(hangul.GetType());
            Console.WriteLine(st.GetType());
            Console.WriteLine(v.GetType());         // System.Single = Float형
            Console.WriteLine();

            // 변수 중복 선언X
            // 변수 선언, 값 설정, 변수 초기화

            // * 특정 타입의 표현 가능한 값의 최대/최소 출력해보기
            Console.WriteLine(int.MinValue + "부터 " + int.MaxValue + "까지 int는 표현 가능");
            Console.WriteLine();

            // 강제 형변환
            Console.WriteLine((double)1 / 3);   // 1 값을 double형으로 취급
            Console.WriteLine((int)'긁');        // 유니코드 기반의 값 출력
        }
    }
}
