using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

// namespace :: 변수명 중복될 때, 별도의 공간을 만들어서 중복을 방지
// 하나의 프로젝트에 여러 파일(.cs)을 만들어도 오류가 생기지 않게 하기 위함
namespace _0328
{
    public class User
    {
        // 클래스 구성 요소 :: 속성(멤버 변수), 메소드(멤버 함수), 생성자

        // 접근 제어자 :: 멤버의 접근을 제어하는 구문
        // "public", private, protected(상속), internal
        // internal :: 같은 프로젝트 내부에서는 접근O, 다른 프로젝트 내부에선 접근X
        //   (ex) 0328 내의 모든 파일에선 접근O, 외부의 Example의 파일에선 접근X

        // 속성 :: 각 인스턴스/객체의 상태값
        // { get; set; }를 통해서, getter(값 반환) 및 setter(값 설정) 정의
        // getName(), getId(), SetName(), setId()   => X
        // get { return Name; }
        // set { Name = value; }

        public string Name { get; private set; }
        // 값 불러오기 자유, 값 설정하는 건 클래스 내부에서만
        private string Id { get; set; }
        //{
        //    get { return Id; }
        //    set     // ""으로 설정하려할 시, 경고창 출력하면서 set 진행X
        //    {
        //        if(value == "")     // Exception()
        //        {
        //            Console.WriteLine("ID는 공란으로 둘 수 없습니다.");
        //            return;
        //        }
        //        Id = value;
        //    }
        //}
        private string Password { get; set; }       

        // 생성자 :: 메소드 중 일부, 객체 생성하는 메소드
        // 객체 생성하는 구문에서만 호출, 임의로 호출X
        public User()
        {
            this.Name = "None";
            this.Id = "None";
            this.Password = "0000";
        }
        // 3개의 string값을 매개변수 받고, 이 값을 통해서 속성값들을 초기화
        public User(string n, string i, string p)
        {
            this.Name = n;
            this.Id = i;
            this.Password = p;
        }

        // 메소드 :: 각 인스턴스/객체의 행위 정의
        public void Print_Info()
        {
            // this :: "이 객체", 메소드를 호출한 인스턴스를 가리킴
            Console.WriteLine($"이름: {this.Name}");
            Console.WriteLine($"아이디: {this.Id}");
            Console.WriteLine($"비밀번호: {this.Password}");
        }
        // login_test(string, string) ::
        //      2개의 string값(id, password) 매개변수로 받고,
        //      인스턴스에 저장된 id, password랑 비교해서,
        //      각 값이 동일하면 로그인, 아니면 로그인 실패 출력
        public void login_test(string i, string p)
        {
            if(this.Id == i && this.Password == p)
            {
                Console.WriteLine("로그인 성공");
            }
            else
            {
                Console.WriteLine("로그인 실패");
            }
        }
    }

    internal class @class
    {
        static void Main(string[] args)
        {
            // 객체 생성
            // [클래스명] [인스턴스명] = new [생성자 호출];
            User lee = new User();
            // 멤버 접근 :: [인스턴스명].[멤버이름]
            // lee.Name = "Lee";
            Console.WriteLine("lee유저 이름 : " + lee.Name);
            // lee.Id = "dbskakfl";
            Console.WriteLine();

            lee.Print_Info();
            Console.WriteLine();

            User kim = new User("Kim", "kim0099", "12345");
            kim.Print_Info();
            Console.WriteLine();

            kim.login_test(Console.ReadLine(), Console.ReadLine());
            // 2개의 입력문 수행 -> login_test() 실행
        }
    }
}
