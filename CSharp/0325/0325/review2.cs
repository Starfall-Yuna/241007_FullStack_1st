using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _0325
{
    internal class review2
    {
        // Main(O) main(X)
        static void Main(string[] args)
        {
            // 조건문 :: 특정 조건을 만족할 때, 수행할 명령문 지정 활용
            // if - else if - else
            Console.Write("초를 입력해주세요: ");
            int sec = int.Parse(Console.ReadLine());

            if (sec >= 3600)
            {
                Console.WriteLine("오류 발생");
            }
            else
            {
                // 입력받은 초를 기반으로, m분 s초로 출력
                // 1분 = 60초
                // 입력값을 60으로 나눈 몫 -> 분 환산
                int m = sec / 60;
                // 입력값을 60으로 나눈 나머지 -> 초 환산
                int s = sec % 60;
                // (ex) 150초    -> 2분 30초
                Console.WriteLine($"{m}분 {s}초");
            }
            Console.WriteLine();

            // switch
            // (범위 설정에 대한 조건식은 switch 적용X)
            // 돈과 메뉴를 입력받고
            // 음료가 나왔다는 안내와 함께 거스름돈 출력
            // < 돈이 부족할 수 있다는 상황은 제외하고 구현 >
            Console.Write("돈을 넣어주세요. ");
            int money = int.Parse(Console.ReadLine());
            Console.Write("메뉴를 입력해주세요.(1번 콜라(1500원), 2번 보리차(2500원)) ");
            int menu = int.Parse(Console.ReadLine());
            // C#의 switch :: 반드시 하나의 케이스만 실행 (복수 케이스 실행X)
            switch (menu)   
            {
                case 1:
                    money -= 1500;
                    Console.WriteLine("콜라가 나왔습니다.");
                    Console.WriteLine($"거스름돈은 {money}원입니다.");
                    break;
                case 2:
                    money -= 2500;
                    Console.WriteLine("보리차가 나왔습니다.");
                    Console.WriteLine($"거스름돈은 {money}원입니다.");
                    break;
                default:    // 잘못 입력받은 경우
                    Console.WriteLine("메뉴를 잘못 눌렀습니다.");
                    Console.WriteLine($"{money}원을 반환합니다.");
                    break;
            }
        }
    }
}
