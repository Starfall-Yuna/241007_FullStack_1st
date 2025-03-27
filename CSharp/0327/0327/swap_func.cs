using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0327
{
    internal class swap_func
    {
        // swap() 함수 구현 ::
        //  - 배열을 매개변수로 받고
        //  - 배열의 크기가 2가 아닌 경우엔, 배열을 그대로 반환
        //  - 배열의 크기가 2인 경우엔, 2개의 값 위치 바꾸기
        static int[] swap(int[] array)
        {
            if (array.Length != 2)
            {
                Console.WriteLine("배열의 크기가 2가 아닙니다.");
            }
            else
            {
                // swap 기초 원리
                int tmp = array[1];
                array[1] = array[0];
                array[0] = tmp;
            }
            return array;
        }

        static void Main(string[] args)
        {
            // 2의 크기를 갖는 배열을 선언하고
            // 2개의 입력값으로 배열을 채우기
            // swap() 함수 실행

            int[] number = new int[2];
            number[0] = int.Parse(Console.ReadLine());
            number[1] = int.Parse(Console.ReadLine());
            number = swap(number);      // number의 원소를 교체하여 값 갱신
            Console.WriteLine(number[0] + " " + number[1]);
        }
    }
}
