using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0401
{
    internal class Ex_interface
    {   
        // - Ielectric(전자기기) :: turnOn(), turnOff()
        public interface Ielectric
        {
            void turnOn();
            void turnOff();
        }
        // - ICalc(연산) :: add(), sub(), mul(), div()
        public interface ICalc
        {
            double add();
            double sub();
            double mul();
            double div();
        }


        // - Calculator(계산기) ::  
        public class Calculator : Ielectric, ICalc
        {
            //	- 속성 :: OnOff, num1, num2, result(연산결과 저장)
            public bool OnOff { get; set; }
            public int num1 { get; set; }
            public int num2 { get; set; }
            public double result { get; set; }

            //	- 생성자 :: 2개의 매개변수를 기반으로 num1, num2 초기화
            public Calculator(int n1, int n2)
            {
                this.OnOff = false;
                this.num1 = n1;
                this.num2 = n2;
            }

            //	- 메소드 :: 각 인터페이스 메소드(총 6개) 구현
            // 1. Ielectric 인터페이스의 메소드 구체화
            public void turnOn()
            {
                Console.WriteLine("전원을 킵니다.");
                this.OnOff = true;
            }
            public void turnOff()
            {
                Console.WriteLine("전원을 끕니다.");
                this.OnOff = false;
            }
            // 2. ICalc 인터페이스의 메소드 구체화
            //    (이때, add(), sub(), mul(), div() 는 숫자형을 반환해야함)
            public double add() { result = num1 + num2; return result; }
            public double sub() { result = num1 - num2; return result; }
            public double mul() { result = num1 * num2; return result; }
            public double div() { result = num1 / num2; return result; }
        }
        static void Main(string[] args)
        {
            // - Main 함수
            // 1) 2개의 정수형과 1개의 연산 기호(+, -, *, / 중 하나) 입력받기
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char oper = char.Parse(Console.ReadLine());

            // 2) Calculator 생성자 실행하여 c 객체 생성
            Calculator c = new Calculator(n1, n2);

            // 3) c 객체 turnOn() 실행
            c.turnOn();

            // 4) 연산 기호에 맞게끔, 사칙연산을 수행하여 결과값 출력
            // 아래 출력 결과 :: c.result의 값
            switch (oper)
            {
                case '+':
                    Console.WriteLine("덧셈 결과: " + c.add());
                    break;
                case '-':
                    Console.WriteLine("뺄셈 결과: " + c.sub());
                    break;
                case '*':
                    Console.WriteLine("곱셈 결과: " + c.mul());
                    break;
                case '/':
                    Console.WriteLine("나눗셈 결과: " + c.div());
                    break;
            }

            // 5) c 객체 turnOff() 실행
            c.turnOff();
        }
    }
}
