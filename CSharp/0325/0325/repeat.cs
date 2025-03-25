using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0325
{
    internal class repeat
    {
        static void Main(string[] args)
        {
            // 반복문 :: 특정 조건을 만족할 때마다, 반복할 명령문 지정 활용
            // while, do-while(생략X), for
            // break, continue, goto(권장X)

            int n = int.Parse(Console.ReadLine());
            // 선언부에 있는 변수는 반복문에서만 유효
            for (int i=1; i<=n; i++)     // 선언부; 조건부; 증감부
            {
                if (i % 2 == 0) { continue; }       // 반복문의 처음으로 감 (i++ 위치)
                Console.WriteLine($"{i}번째 출력입니다.");
            }
            Console.WriteLine();

            int a = 1;
            while (true)    // a <= n
            {
                if (a % 2 == 0) {
                    a++;    // for문에선, continue문을 만나도 i++ 실행
                    continue; 
                }

                Console.WriteLine($"{a}번째 출력입니다.");
                if (a > n) { break; }       // 반복문 실행 중단
                                            // (중단할 시점을 명령문 사이에 해야할 때 사용)
                a++;
            }
        }
    }
}
