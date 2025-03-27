using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0327
{
    internal class try_parse
    {
        static void Main(string[] args)
        {
            // (자료형).Parse(입력문) -> 실수로 다른 타입 입력하면, 콘솔에서 막힘
            // TryParse :: 
            // "111"을 int로 파싱한 결과를 input에 저장 (파싱 성공 여부를 check1 저장)
            int input;
            bool check1 = int.TryParse("111", out input);
            // << input - TryParse의 두번째 매개변수 간 값이 연결 >> 
            Console.WriteLine(input + " " + check1);

            double dnum;
            bool check2 = double.TryParse(Console.ReadLine(), out dnum);
            Console.WriteLine(dnum + " " + check2);
            // 파싱 실패하면, 변수에는 0(false)을 저장 + 파싱 성공 여부도 false 반환

            char ch;
            char.TryParse(Console.ReadLine(), out ch);
            Console.WriteLine(ch);      // 실패하면 ""로 저장
        }
    }
}
