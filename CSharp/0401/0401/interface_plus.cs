using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 상속 :: 클래스 간의 공통점을 정의 (부모/자식 클래스처럼 상위/하위 개념 생김)
// 추상 클래스 :: "abstract", "덜 구현된 클래스"    => 자식 클래스에서 상속받아 구체화 필요
// 추상 메소드 :: "abstract", "덜 구현된 메소드"                => 자식 클래스에서 재정의(오버라이딩)

// 오버라이딩 :: virtaul(재정의를 당하는 쪽), override(재정의를 하는 쪽)

namespace _0401
{
    internal class interface_plus
    {
        // 인터페이스 :: 구현해야할 멤버로만 구성
        // "주로 메소드(기능) 선언만 하는 편" (인터페이스를 사용하는 클래스의 공통적인 속성을 정의)

        // 로봇 인터페이스
        public interface IRobot
        {
            void turnOn();      // public, abstract 키워드 생략
            void turnOff();
        }

        // 반려자 인터페이스
        public interface ICompanion
        {
            void beCute();
        }

        // 반려강아지 클래스 (로봇 인터페이스, 반려자 인터페이스 상속)
        // 다중 상속 :: 여러 개의 인터페이스 상속 (부모 인터페이스가 2개 이상인 경우)
        public class RobotDog : IRobot, ICompanion      // :(콜론)으로 인터페이스 상속
        {
            // 속성 :: 주인이름(OwnerName), 전원 여부(OnOff)
            public string OwnerName { get; set; }
            public bool OnOff { get; set; }

            public RobotDog()
            {
                this.OwnerName = "None";
                this.OnOff = false;
            }

            // 반려자 인터페이스(ICompanion) 메소드 구체화
            public void beCute()
            {
                Console.WriteLine($"{this.OwnerName}님, 쓰다듬어 주세요~");
            }

            // 자기 자신의 메소드
            public void setOwner()
            {
                if (this.OnOff == false) { return; }

                Console.Write("당신의 이름은 무엇인가요? ");
                this.OwnerName = Console.ReadLine();
                Console.WriteLine($"{this.OwnerName}님, 잘 부탁드릴께요!");
            }

            // 로봇 인터페이스(IRobot) 메소드 구체화 (오버라이딩)
            public void turnOn()
            {
                Console.WriteLine($"{this.OwnerName}님, 안녕하세요!");
                this.OnOff = true;
            }
            public void turnOff()
            {
                Console.WriteLine($"{this.OwnerName}님, 잠시 쉬다 올께요!");
                this.OnOff = false;
            }
        }

        static void Main(string[] args)
        {
            RobotDog rd = new RobotDog();
            rd.turnOn();        // IRobot 메소드
            rd.setOwner();
            rd.beCute();        // ICompanion 메소드
            rd.turnOff();       // IRobot 메소드
        }
    }
}
