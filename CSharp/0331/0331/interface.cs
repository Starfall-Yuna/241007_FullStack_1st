using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0331
{
    internal class @interface
    {
        // 인터페이스 :: 구체화된 것 없이 틀만 제시, 구현이 필요한 멤버로만 구성 (객체 생성X)
        
        // 인터페이스 구성요소 :: 속성, 추상 메소드(abstract 키워드X)
        //      대부분은, 추상 메소드로만 구성
        //      (구체화를 진행할 클래스에 공통되는 속성이 있으면, 속성도 넣긴 함)

        // 로봇에 대한 기능 인터페이스
        public interface IRobot
        {
            void turnOn();
            void turnOff();
        }

        public class RobotDog : IRobot      // 인터페이스 구체화에도 :(콜론) 사용
        {
            // 속성 :: 주인이름(OwnerName), 전원(OnOff)
            public string OwnerName { get; set; }
            public bool OnOff { get; set; }

            public RobotDog()
            {
                this.OwnerName = "None";
                this.OnOff = false;
            }

            // 자기 자신의 메소드
            public void setOwner()
            {
                if(this.OnOff == false) { return; }     // 전원 꺼져있으면, 동작 안함

                // 이 함수 내에서 string값 입력 -> 이 값으로 OwnerName 설정
                Console.Write("당신의 이름은 무엇인가요? ");
                this.OwnerName = Console.ReadLine();
                Console.WriteLine($"{this.OwnerName}님, 잘 부탁드릴께요!");
            }

            // turnOn(), turnOff() :: IRobot의 구체화가 필요한 메소드
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
            RobotDog rd = new RobotDog();     // OwnerName: "None", OnOff: false
            rd.turnOn();
            rd.setOwner();
            rd.turnOff();
        }
    }
}
