using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _0328
{
    internal class review
    {
        static void change_ch(ref char c1)
        {
            c1 = 'g';
        }
        static void add(out int result, char c1, char c2)       // 2개의 문자에 대해서, 코드값 합한 연산
        {
            // ref 성질 + add()에서 반드시 "값이 새로 할당"되야함 => out 키워드
            result = c1 + c2;
        }
        static void Main(string[] args)
        {
            // 참조 복사 키워드 :: ref, out
            // 전달받는 변수, 전달하는 변수에도 키워드 모두 사용
            
            // (1) 
            char h1 = '긹';
            ref char copy_h = ref h1;       // copy_h :: h1의 값, h1의 메모리 주소
            copy_h = '핳';
            Console.WriteLine(h1 + " " + copy_h);

            // change_ch(h1);      // h1의 값만 전달 (독립적)
            change_ch(ref h1);      // change_ch()의 c1이 변경 -> h1값도 함께 변경
            Console.WriteLine(h1);

            int r = 0;
            add(out r, h1, copy_h);     // r에, h1+copy_h 결과값 전달받음 (add()의 result 인해)
            Console.WriteLine(r);

            // (자료형).TryParse(파싱을 시도할 값, out 변수)
            // => 파싱 실패로 인해서 콘솔에서 생기는 에러 방지
            // => 반환형은 bool형 (파싱 성공 여부)
            // => 파싱을 시도해보고, 이 결과를 out 변수로 넘겨줌 (실패하면 0, false, "" 반환)
        }
    }
}
