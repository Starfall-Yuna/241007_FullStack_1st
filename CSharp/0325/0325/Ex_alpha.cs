using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _0325
{
    internal class Ex_alpha
    {
        static void Main(string[] args) 
        {
            // 숫자 n을 입력받고
            // n개의 문자를 입력받는다.
            // n개의 문자를 오름차순 정렬하여 결과를 출력하라
            // (아스키코드/유니코드 기반으로 정렬을 하고, 한글/알파벳/기호 모두 상관X)

            int n = int.Parse(Console.ReadLine());
            List<char> alpha = new List<char>();    // n개의 문자를 저장할 빈 리스트
            for(int i=0; i < n; i++)
            {
                char a = char.Parse(Console.ReadLine());
                alpha.Add(a);
            }
            Console.WriteLine();

            // 1. 오름차순 정렬하는 함수 활용
            // Sort() :: 오름차순 정렬 수행     -> 컬렉션(배열, 리스트) 함수
            // 배열 :: Array.Sort(배열이름);
            // 리스트 :: (리스트이름).Sort();
            alpha.Sort();

            foreach(char c in alpha)    // 변수 c로, alpha 요소 하나씩 접근
            {
                Console.WriteLine(c + " " + (int)c);
            }

            // 2. 함수 활용X, 2중 반복문 활용 (모든 요소들에 대해 비교)
            //      'c', 'a'    => (자리 교체) =>  'a', 'c'    
        }
    }
}
