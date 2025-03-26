using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0326
{
    internal class Overloading
    {
        static int add()            // 매개변수 없음
        {
            return 0;
        }
        //static double add()     // 매개변수 구성 같고, 반환형 다름   -> 오버로딩 취급X
        //{
        //    return 0;
        //}
        static int add(int n1)      // 매개변수 int형 1개
        {
            return n1;
        }
        static int add(int n1, int n2)  // 매개변수 int형 2개
        {
            return n1 + n2;
        }

        static void Main(string[] args)
        {
            // 오버로딩 :: "함수 이름이 동일하여도, 매개변수 구성이 다르면 함께 활용 가능"
            //Console.WriteLine("add() 실행: " + add());    // 첫번째 add() 실행
            //Console.WriteLine("add(5) 실행: " + add(5));  // 두번째 add() 실행

            // 숫자 n 입력하고
            int n = int.Parse(Console.ReadLine());
            // n개의 크기의 배열을 선언
            int[] number = new int[n];
            // n개의 숫자를 입력받아서, number에 하나씩 저장
            for(int i=0; i < number.Length; i++)
            {
                int num=int.Parse(Console.ReadLine());
                number[i] = num;
            }

            // switch문 + 3개의 add 함수     -> number 원소들의 총합을 출력
            // case(경우) 나누는 기준 :: number 배열의 길이에 따라 수행할 add() 함수 달리할 예정
            switch (number.Length)
            {
                case 0:
                    // add() 내용 :: 0 반환
                    Console.WriteLine("배열의 길이가 없는 관계로, 0을 수행합니다.");
                    Console.WriteLine("add() 수행 결과: " + add());
                    break;
                case 1:
                    // add(int) 내용 :: 매개변수값 그대로 반환
                    Console.WriteLine("배열의 길이가 1인 관계로, 원소의 값을 그대로 출력합니다.");
                    Console.WriteLine("add() 수행 결과: " + add(number[0]));
                    break;
                default:
                    // 배열의 길이가 2 이상인 경우엔, default에서 총합을 출력할 예정
                    // add(int, int)를 통해서 총합을 출력할 예정
                    for (int i=1; i < number.Length; i++)
                    {
                        // number[i] = number[i - 1] + number[i];
                        number[i] = add(number[i - 1], number[i]);
                    }
                    foreach(var item in number)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("add()의 수행 결과: " + number[n - 1]);
                    break;

                    // "누적 합" 알고리즘 기초
            }
        }
    }
}
