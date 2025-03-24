using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0324
{
    internal class @while
    {
        static void Main(string[] args)
        {
            // 반복문 :: 특정 조건 만족할 때마다, 반복할 명령문 지정 활용
            // for, "while", do-while
            // break, continue, goto(권장X)

            int num = int.Parse(Console.ReadLine());
            while (true)   // num--처럼, bool 결과값이 명확X 구문 조건식에 작성하지 못함 
            {
                // if (num % 2 == 0) { continue; }      // 반복문의 처음으로 돌아감
                if (num % 2 == 0) { goto END; }     // END 분기점으로 이동
                // num이 짝수인 경우, 출력문 수행X 무한 반복    
                Console.WriteLine($"{num}번 남았습니다.");
                if (num == 0) { break; }
                num--;
            }   // break :: 반복문 중단

            // "END" 분기점 생성
            END:
                Console.WriteLine("goto 구문으로, 반복문이 종료되었습니다.");

            // goto :: 코드의 흐름을 사용자 마음대로 제어 -> 권장X (가독성 낮아짐)
        }
    }
}
