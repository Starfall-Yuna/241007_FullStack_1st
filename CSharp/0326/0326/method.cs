using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0326
{
    internal class method
    {
        // 메소드(함수) :: 명령문의 묶음
        // 반환형 메소드이름(매개변수 구성)   { 실행할 명령문들 }
        // 반환형이 void이면 return문 사용X, 그 이외엔 모두 return형 필요로 함

        // 전역 함수(일반적인 함수)   -> static 키워드 사용 (호출에 지장이 없게끔)
        static void print_time(int h, int m)
        {
            Console.WriteLine($"현재 시각은 {h}시 {m}분입니다.");
        }
        static void Main(string[] args)
        {
            // C#에서는 Main 안에 함수 구현 가능   -> 지역 함수(로컬 함수)
            // 지역 함수는 Main 안에서만 활용 가능
            void print_hello()
            {
                Console.WriteLine("안녕하세요~");
            }

            // 함수 호출
            print_hello();
            print_time(11, 16);

            // 지역함수랑 전역함수 이름이 똑같으면 발생하는 문제
            //  => 전역함수의 존재를 Main에서 파악X
            // 동일한 이름으로 지역함수와 전역함수를 혼용해서 사용 => 권장X
        }
    }
}
