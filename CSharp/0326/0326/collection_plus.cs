using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0326
{
    internal class collection_plus
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 7, 3, 1, 9 };        // 초기값 설정된 배열
            List<int> list = new List<int>();
            for(int i=0; i < 5; i++)
            {
                // 입력값 삽입하여 리스트 구성
                int num = int.Parse(Console.ReadLine());
                list.Add(num);
            }

            // Reverse() :: 기존 순서를 반전시켜 구성
            // { 5, 7, 3, 1, 9 }    => { 9, 1, 3, 7, 5 }
            Array.Sort(array);          // 오름차순 정렬               { 1, 3, 5, 7, 9 }
            Array.Reverse(array);       // 오름차순 정렬 결과를 뒤집기 { 9, 7, 5, 3, 1 }
            list.Sort();
            list.Reverse();

            // 배열값 순서대로 조회
            foreach(var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            // 리스트값 순서대로 조회
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
