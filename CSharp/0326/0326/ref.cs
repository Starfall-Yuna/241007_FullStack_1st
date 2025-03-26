using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _0326
{
    internal class @ref
    {
        static void change_ch(char c)
        {
            c = '가';
        }
        static void Main(string[] args)
        {
            // call by value (값 전달 방식 -> 값 복사)
            char ch = '긝';
            change_ch(ch);      // 문자값만 전달 (ch 메모리 정보 전달X)
            Console.WriteLine("change_ch(ch) 실행한 결과 : " + ch);
            Console.WriteLine();
            // "ch의 값이 변경되었는가?"

            int n1 = 10;
            // int n2 = n1;    // call by value (값 전달 방식 -> 값 복사)
            ref int n2 = ref n1;    // n2에선 n1의 값과 메모리 주소를 함께 전달받음
            Console.WriteLine($"n1, n2의 값: {n1}, {n2}");
            n2 = 12345;     // 전달받은 메모리 주소도 참조하여, n1의 값도 함께 변경
            Console.WriteLine($"n1, n2의 값: {n1}, {n2}");
            // "n1과 n2가 둘 다 변경되었는가, n2만 변경되었는가?"

            // ref 키워드 :: 값과 메모리 주소를 함께 전송할 때 사용
        }
    }
}
