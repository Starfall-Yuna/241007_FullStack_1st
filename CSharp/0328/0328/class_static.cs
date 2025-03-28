using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _0328
{
    // Americano 클래스 생성
    public class Americano
    {
        // 인스턴스 멤버 :: 특정 인스턴스를 통해서 (함수)호출/(변수)참조
        //      ame1, ame2에 있어, 각각 다른 속성값/행위를 보일 수 있음
        // 클래스 멤버 :: 동일한 클래스의 인스턴스가 모두 같게 동작되는 멤버
        //      (속성) :: 객체들이 같은 값을 공유하여 활용
        //      (메소드) :: 객체들이 같은 행위를 수행하여 활용
        //      ame1, ame2에 있어, 동일한 속성값/행위를 보일 수 있음

        // 속성 :: water(물의 양), ess(에스프레소 양)
        public int water { get; set; }
        public int ess { get; set; }
        public static string menu_name { get; set; }        // 클래스 속성

        // 메소드 ::
        // [클래스이름].Print_Menu()
        public static void Print_Menu()     // 클래스 메소드
        {
            // 주의 :: 인스턴스 멤버 호출X
            Console.WriteLine($"{menu_name} 나왔습니다.");
        }
        //  - Print_Info() :: 속성값 순차 출력
        public void Print_Info()
        {
            Console.WriteLine($"물의 양: {this.water}ml");
            Console.WriteLine($"에스프레소의 양: {this.ess}ml");
        }
        //  - Check_Balance() :: 물의 양:에스프레소 양이 2:1인지 체크하고
        //      비율이 맞다면, "비율이 맞습니다." 출력
        //      비율이 안 맞다면, "비율이 맞지 않습니다." 출력
        public void Check_Balance()
        {
            // water : ess = 2 : 1      => water = ess*2
            if(water == ess * 2)
            {
                Console.WriteLine("비율이 맞습니다.");
            }
            else
            {
                Console.WriteLine("비율이 맞지 않습니다.");
            }
        }

        // 생성자 (오버로딩) ::
        //  - Americano() :: water, ess 모두 0으로 초기화
        //  - Americano(int, int) :: 매개변수 값으로 water, ess 초기화
        public Americano()
        {
            this.water = 0;
            this.ess = 0;
        }
        public Americano(int w, int e)
        {
            this.water = w;
            this.ess = e;
        }
    }

    internal class class_static
    {
        static void Main(string[] args)
        {
            Americano ame1 = new Americano();
            // [인스턴스명].[멤버명]    => 인스턴스 멤버 호출
            ame1.Print_Info();
            ame1.Check_Balance();
            Console.WriteLine();

            Americano ame2 = new Americano(100, 100);
            ame2.Print_Info();
            ame2.Check_Balance();
            Console.WriteLine();

            // [클래스명].[멤버명]     => 클래스 멤버(static) 호출
            Americano.menu_name = "아메리카노";
            Console.WriteLine("메뉴 이름: " + Americano.menu_name);

            Americano.Print_Menu();
        }
    }
}
