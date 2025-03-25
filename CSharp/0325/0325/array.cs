using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0325
{
    internal class array
    {
        static void Main(string[] args)
        {
            // 배열 :: 여러 개의 값을 하나의 이름으로 저장할 수 있는 변수      -> 컬렉션
            // 어떤 선언 방법으로든 "크기를 반드시 명시"
            int[] number = { 1, 3, 5, 7, 9 };       // 크기가 자동으로 5로 설정
            double[] pi = new double[3];            // 공간만 할당
            char[] hello = new char[] { 'h', 'e', 'l', 'l', 'o' };  // 크기가 자동으로 5로 설정
            string[] st = new string[2] { "hello", "world" };       // 값도 크기도 모두 명시

            Console.WriteLine(number);      // 배열 이름 -> 배열의 타입 반환
            Console.WriteLine($"number의 3번째 값: {number[2]}");
            pi[1] = 3.1;
            Console.WriteLine($"pi의 2번째 값: {pi[1]}");

            // (배열이름).Length :: 배열 길이 반환
            Console.WriteLine(number.Length);
            Console.WriteLine(hello.Length);

            Console.WriteLine("number의 원소를 순차적으로 출력합니다.");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] +" ");
            }
            Console.WriteLine();

            // hello의 각 값에 대해서 출력하기 (foreach)
            foreach (var item in hello)     // item 타입 :: char형으로 지정
            {
                Console.WriteLine(item);    // item :: h -> e -> l -> l -> o
            }
        }
    }
}
