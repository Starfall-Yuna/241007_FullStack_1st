using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0327
{
    internal class review
    {
        // 메소드(함수) :: 명령문의 묶음
        // 오버로딩 :: "함수 이름이 같아도, 매개변수 구성이 다르면 함께 활용O"
        // 지역함수-전역함수 함께 활용하여 오버로딩 구현 권장X    -> 전역함수 인식X
        static void try_login(string id, string pw)
        {
            if (id == "admin" && pw == "1234") { Console.WriteLine("로그인에 성공하였습니다."); }
            else { Console.WriteLine("로그인에 실패하였습니다."); }
        }
        static void try_login(string pw)
        {
            if (pw == "1234") { Console.WriteLine("로그인 성공"); }
            else { Console.WriteLine("로그인 실패"); }
        }

        static void Main(string[] args)
        {
            // 지역 함수 :: Main 함수 안에서만 활용O

            Console.WriteLine("로그인 시도 :: ");
            try_login("admin", "1234");
            Console.WriteLine("로그인 시도 :: ");
            try_login("1111");
        }
    }
}
