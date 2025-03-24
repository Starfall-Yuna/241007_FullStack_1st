using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0324
{
    internal class input
    {
        static void Main(string[] args)
        {
            // 입력문 :: Console.ReadLine()
            // 입력받은 뒤, 입력값을 어디에 저장할지 명시
            // 기본적으로 string형으로 입력을 받음   -> 정수든, 실수든, 문자든 모두 string형으로

            // 입력값에 따라서, input의 자료형 결정  -> var 키워드
            var input = Console.ReadLine();
            Console.WriteLine(input);
            Console.WriteLine(input.GetType());

            int num = int.Parse(Console.ReadLine());    // int.Parse로, string형 -> int형 읽어들임
            double dnum = double.Parse(Console.ReadLine()); // double.Parse로, string형 -> double형 읽어들임
            Console.WriteLine(num + " " + dnum);
            // 타입에 맞지 않게 입력을 하면, 콘솔 상에서 에러 발생
        }
    }
}
