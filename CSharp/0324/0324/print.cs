using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0324
{
    internal class Program
    {
        // C#에선 대소문자 구분
        // 메인 함수 (프로그램 실행의 기준점, main(X))
        static void Main(string[] args)
        {
            // 한줄 주석
            /*
                여러 줄 주석 
            */
            // 주석 단축키 :: (주석 설정)Ctrl + k + c, (주석 해제)Ctrl + k + u

            // 출력문 :: Console.Write(), Console.WriteLine()
            // (단축키 :: cw 입력 + Tab 2번)
            Console.Write("첫번째 출력");        
            Console.WriteLine("두번째 출력");    // 출력 수행 후 개행 진행

            // 출력문 포맷 방법
            Console.WriteLine("10+20은 " + (10 + 20) + "입니다.");
            Console.WriteLine(string.Format("알파벳의 세번째 문자는 {0}입니다.", (char)('A' + 2)));
            // 0번째에 위치한 (char)('A' + 2) 값을 {0}에 대입
            Console.WriteLine($"소문자와 대문자의 아스키코드 값의 차이는 {'a'-'A'}입니다."); 
        }
    }
}
