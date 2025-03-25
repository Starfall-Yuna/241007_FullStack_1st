using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0325
{
    internal class list
    {
        static void Main(string[] args)
        {
            // 리스트 :: 여러 개의 값을 하나의 이름으로 저장할 수 있는 변수     -> 컬렉션
            // 배열과는 달리, 크기 지정X (크기 변동O)
            List<double> pi = new List<double>();       // 리스트 선언
            List<char> alpha = new List<char>() { 'a', 'b'};    // 2개의 초기값 삽입, 리스트 선언

            // (리스트).Count :: 리스트 길이 반환

            // Add() :: 리스트 뒤로 값 삽입
            // Insert() :: 리스트의 특정 위치에 값 삽입
            pi.Add(3.1);
            pi.Add(3.14);
            pi.Add(3.1415);
            pi.Insert(2, 3.141);    // 2번 공간에 값 삽입
            Console.WriteLine(pi.Count);
            foreach (var item in pi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Remove() :: 특정 값을 삭제
            pi.Remove(3.1415);
            // RemoveAt() :: 특정 위치의 값을 삭제
            pi.RemoveAt(1);
            Console.WriteLine(pi.Count);
            foreach (var item in pi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Clear() :: 모든 값을 삭제 (리스트 공간은 남아있음)
            pi.Clear();
            Console.WriteLine(pi.Count);
        }
    }
}
