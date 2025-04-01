using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _0331
{
    internal class @abstract
    {
        // 추상 클래스 :: "추상적인 클래스", 자식 클래스에서 구체화 필요 (상속 필수)
        //      추상 클래스로는 객체 생성X
        // 추상 메소드 :: "추상적인 메소드", 선언만 하고 구현이 안 된 메소드
        //  => "abstract" 키워드 사용
        public abstract class Animal
        {
            // "덜 구현된 클래스"  => 구체화된 메소드도, 추상적인 메소드도 선언
            public abstract void cry();     // 추상 메소드
            // 추상 메소드 자체가 재정의 필요   -> virtual 키워드로 재정의할 것이라 명시 필요X

            public virtual string getName()         // 일반적인 메소드
            {
                return "None";
            }
        }
        public class Dog : Animal       // 에러 내용 :: cry() 구체화 필요
        {
            public override void cry()       // Animal.cry() "오버라이딩" 진행
            {
                Console.WriteLine("월월월월");
            }
            public override string getName()
            {
                return "강아지";
            }
        }
        // 클래스 Bird(새) 작성   -> Animal 상속받아서, Dog와 비슷한 형식 작성
        public class Bird : Animal
        {
            public override void cry()
            {
                Console.WriteLine("짹짹");
            }
            public override string getName()
            {
                return "새";
            }
        }


        static void Main(string[] args)
        {
            // Animal a = new Animal();         // 객체 생성X
            Dog d = new Dog();
            d.cry();
            Console.WriteLine(d.getName());

            Bird b = new Bird();
            b.cry();
            Console.WriteLine(b.getName());
        }
    }
}
