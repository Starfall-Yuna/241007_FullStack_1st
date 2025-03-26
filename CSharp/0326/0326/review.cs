using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0326
{
    internal class review
    {
        static void Main(string[] args)
        {
            // 배열, 리스트 :: 여러 값을 하나의 이름 저장 (컬렉션)
            // 배열은 크기 지정O, 리스트는 크기 지정X

            // 배열 선언
            string[] todo = { "공부", "밥 먹기", "노트 정리" };      // 자동으로 3의 크기 가짐
            int[] grade = new int[6];       // 6의 크기 가짐 (초기값X)

            // 배열값 정렬 :: Sort()
            Array.Sort(todo);
            for(int i=0; i<todo.Length; i++)
            {
                Console.WriteLine($"{i + 1}번째 할일 :: {todo[i]}");
            }
            Console.WriteLine();
            foreach (var item in todo)  // item을 통해, todo의 데이터 하나씩 접근
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // 리스트 선언
            List<double> pi = new List<double>();   // 빈 리스트 선언
            List<char> hangul = new List<char>() { '가', '나', '다' };     // 초기값을 넣어서 리스트 선언

            for (int i = 0; i < hangul.Count; i++) 
            {
                Console.Write(hangul[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // 값 삽입 :: Add(), Insert()
            // 값 삭제 :: Remove(), RemoveAt()
            hangul.Add('마');    // 맨 뒤에 요소 삽입
            hangul.Insert(1, '카');      // 1번 공간에 요소 삽입
            foreach (var item in hangul)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            hangul.Remove('가');     // 지정된 값 삭제
            hangul.RemoveAt(1);     // 지정된 위치의 값 삭제
            foreach(var item in hangul)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            hangul.Clear();     // 전체 삭제 (리스트 공간 남아있음)
            Console.WriteLine(hangul.Count);
        }
    }
}
