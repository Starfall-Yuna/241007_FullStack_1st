using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _0331
{
    internal class review
    {
        public class Phone
        {
            // 접근제어자 :: "public", private, protected, internal
            
            // 인스턴스 멤버 :: static 키워드 적지 않은 멤버
            //      => "인스턴스가 갖는 멤버", 각 인스턴스가 독립적으로 갖는 멤버
            //      => (ex) p1의 Number 메모리와 p2의 Number 메모리가 독립적으로 
            // 클래스 멤버 :: static 키워드 적은 멤버
            //      "클래스 이름을 통해서 접근"
            //      => "클래스가 갖는 멤버", 동일한 클래스에서 만들어진 객체들은 공유하는 멤버
            //      => (ex) Phone의 Model 메모리를 모든 객체가 공유

            // 클래스 구성 요소 :: 속성, 메소드, 생성자
            // { get; set; } :: 적으면 속성, 안 적으면 필드
            public string OwnerName { get; set; }
            public string Number { get; private set; }
            public static string Model { get; set; }    
                // 모든 객체가 동일한 Model값을 공유 (p1과 p2는 같은 Model값 가짐)

            // 생성자
            public Phone()
            {
                this.OwnerName = "None";
                this.Number = "000-0000-0000";
            }
            public Phone(string ownerName, string number)
            {
                OwnerName = ownerName;
                Number = number;
            }

            // 메소드
            public void Print_Info()
            {
                Console.WriteLine("이름: " + this.OwnerName);
                Console.WriteLine("전화번호: " + this.Number);
            }
            public static void Print_Song()     // p1, p2가 동일하게 수행할 수 있는 행위
            {
                Console.WriteLine("사랑해요 LG~");
            }
        }
        static void Main(string[] args)
        {
            Phone p1 = new Phone();     // Phone() 생성자 실행
            p1.Print_Info();
            Console.WriteLine();

            Phone p2 = new Phone("Lee", "010-1234-1234");   // Phone(string, string) 생성자 실행
            p2.Print_Info();
            Console.WriteLine();

            // 클래스 멤버 접근 :: 클래스 이름을 통해서 접근 (인스턴스/객체 이름X)
            // p1.Print_Song();
            Phone.Model = "LG";
            Phone.Print_Song();
        }
    }
}
