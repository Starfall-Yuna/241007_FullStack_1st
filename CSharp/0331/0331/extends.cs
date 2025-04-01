using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0331
{
    internal class extends
    {
        // 상속 :: 클래스 간의 "공통점을 정의"하여, 이를 통하여 클래스 간의 관계 성립
        //      (부모/자식 클래스처럼 상위/하위 개념 생김)

        public class Person
        {
            // 접근제어자 protected :: "자기 자신과 자식 클래스에 대해서만 접근 가능"

            // 속성 :: 이름(Name), 생년월일(Birth), 성별(Gender)
            public string Name { get; set; }
            protected string Birth { get; set; }
            public string Gender { get; set; }

            public virtual void setNoneInfo()
            {
                this.Name = "None";
                this.Birth = "0000.00.00";
                this.Gender = "None";
            }
        }

        // 교수(Professor) 클래스 작성
        public class Professor : Person
        {
            // 속성 :: {이름(Name), 생년월일(Birth), 성별(Gender)},   -> 상속받음
            //      소속(Depart), 수업 분야(Education, List)
            public string Depart;
            public List<string> Education;

            // setNoneInfo() :: 위 4개(이름, 생년월일, 성별, 소속)에 대해 임의의 값으로 초기화
            public override void setNoneInfo()
            {
                base.Name = "Blank";
                base.Birth = "1234.12.12";
                base.Gender = "Blank";
                this.Depart = "Blank";
            }
            // setNoneInfo() :: 오버라이딩 + 오버로딩
            public void setNoneInfo(string n, string b, string g, string d)
            {
                base.Name = n;
                base.Birth = b;
                base.Gender = g;
                this.Depart = d;
            }

            // addEducation(string) :: 매개변수로 전달받은 string값을 Education에 추가
            public void addEducation(string e)
            {
                this.Education.Add(e);
            }
        }

        public class Student : Person
        {
            // 속성 :: {이름(Name), 생년월일(Birth), 성별(Gender)}, 학년(Grade), 전공(Major)
            //      => Name, Birth, Gender는 Person으로부터 상속받으면 될 것 같음

            //public string Name { get; set; }
            //public string Birth { get; set; }
            //public string Gender { get; set; }
            public int Grade { get; set; }
            public string Major { get; set; } 

            // 오버라이딩 :: 부모 클래스에 있는 함수 "재정의"
            // 오버라이딩 당하는 쪽에는 virtual, 오버라이딩 하는 쪽에는 override 키워드 추가
            public override void setNoneInfo()      // Person.setNoneInfo() 재정의
            {
                // base :: 이 메소드를 호출한 "객체의 부모 클래스"를 가리킴
                base.Name = "Null";
                base.Birth = "9999.99.99";
                base.Gender = "Null";
                this.Grade = 0;
                this.Major = "Default";
            }
        }

        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Kim";
            s1.setNoneInfo();
            Console.WriteLine(s1.Birth);

            Professor p1 = new Professor();
            p1.setNoneInfo();
            Console.WriteLine(p1.Birth);

            p1.setNoneInfo("Lee", "2000.01.01", "Male", "SW융합학과");
            Console.WriteLine(p1.Birth);
        }
    }
}
