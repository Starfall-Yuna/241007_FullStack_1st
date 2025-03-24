using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0324
{
    internal class @if
    {
        static void Main(string[] args)
        {
            // 조건문 :: 특정 조건 만족할 때, 수행할 명령문 지정 활용
            // if - else if - else
            //var input = Console.ReadLine().Split();
            //int h = int.Parse(input[0]);
            //int m = int.Parse(input[1]);
            //Console.WriteLine($"{h}시 {m}분으로 입력받았습니다.");
            //// 입력받은 시간에 대해서, 오전인지 오후인지 출력
            //if (h >= 0 && h < 12)
            //{
            //    Console.WriteLine("오전(AM)입니다.");
            //}
            //else if (h >= 12 && h < 24) 
            //{
            //    Console.WriteLine("오후(PM)입니다.");
            //}
            //else
            //{
            //    Console.WriteLine("잘못 입력받았습니다.");
            //}

            // 시험 점수를 입력받고
            // 60점 이상이면 합격을 알리는 출력문 수행
            // 60점 미만이면 불합격을 알리는 출력문 수행
            int score = int.Parse(Console.ReadLine());
            if (score >= 60)
            {
                Console.WriteLine("(if)합격입니다.");
            }
            else
            {
                Console.WriteLine("(if)불합격입니다.");
            }

            // switch문
            // case, default 모두 break를 활용 (필수)
            switch (score/10)       // 점수에서, 십의 자리 이상값만 남게 됨
            {
                // 합격 :: 60 ~ 100   --(10으로 나눈 몫)--> 6, 7, 8, 9, 10
                // 10, 9, 8, 7, 6 중 하나에 해당된다면, 
                case 10:
                case 9:
                case 8:
                case 7:
                case 6:
                    Console.WriteLine("(switch)합격입니다!!!");
                    break;
                default:
                    Console.WriteLine("(switch)불합격입니다...");
                    break;  // C#에서는, switch문의 어느 case에서도 명확히 break;를 통해 종료
            }
        }
    }
}
