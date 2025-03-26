using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0326
{
    internal class review2
    {
        static void Main(string[] args)
        {
            // 숫자 n을 입력받고
            // n개의 문자를 입력받는다.
            // n개의 문자를 오름차순 정렬하여 결과를 출력하라
            // (아스키코드/유니코드 기반으로 정렬을 하고, 한글/알파벳/기호 모두 상관X)

            int n = int.Parse(Console.ReadLine());
            List<char> alpha = new List<char>();
            for (int i = 0; i < n; i++) 
            {
                char c = char.Parse(Console.ReadLine());
                alpha.Add(c);
            }
            Console.WriteLine();

            // 1. 오름차순 정렬하는 함수 활용 -> Sort()
            //alpha.Sort();

            //foreach(var giho in alpha)      // giho를 통해서, alpha 원소 순차 접근
            //{
            //    Console.WriteLine(giho + " " + (int)giho);
            //}

            // 2. 함수 활용X, 2중 반복문 활용 (모든 요소들에 대해 비교)
            //      'c', 'a'    => (자리 교체) =>  'a', 'c'

            // v1, v2를 통해서 alpha의 2개 원소쌍을 모두 선택
            // (ex) 3개의 원소 -> 3 * 3 = 9개 쌍의 경우를 모두 따져줌
            //      => 모든 쌍에 대해서, 문자 코드의 크기 비교
            for(int i=0; i < alpha.Count; i++)
            {
                for (int k = i+1; k < alpha.Count; k++) 
                    // j 시작값 = i+1      => j는 항상 i의 오른편에 위치
                {
                    //foreach (var item in alpha) { Console.Write(item + " "); }
                    //Console.WriteLine();
                    if (alpha[i] > alpha[k])
                    {
                        // 교체 진행
                        char tmp = alpha[i];
                        alpha[i] = alpha[k];
                        alpha[k] = tmp;
                    }
                }
            }

            foreach (var giho in alpha)      // giho를 통해서, alpha 원소 순차 접근
            {
                Console.WriteLine(giho + " " + (int)giho);
            }
        }
    }
}
