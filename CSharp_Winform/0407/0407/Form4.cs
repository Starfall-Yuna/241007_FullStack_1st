using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0407
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        // 1) 위 클래스에 대한 리스트(user)를 선언하고, 임의의 데이터 4개 정도 삽입하기
        List<User> user = new List<User>()
        {
            new User{Name = "Lee", Age = 15},
            new User{Name = "Park", Age = 45},
            new User{Name = "Kim", Age = 19},
            new User{Name = "Choi", Age = 20},
            new User{Name = "Cho", Age = 50}
        };


        // 2) 디자인창에서 버튼 2개를 생성 ("성인만 출력", "미성년만 출력")

        // 3) 각 버튼에 대한 이벤트 메소드 생성
        //      - "성인만 출력" :: 리스트 user 중 성인인 유저의 이름을 mbox에 출력
        //      - "미성년만 출력" :: 리스트 user 중 미성년인 유저의 이름을 mbox에 출력
        //  "단, 중복되는 내용을 하나의 메소드에 모아두고, 해당 메소드를 호출하는 방식으로 구현을 진행"
        //      "중복되지 않는 내용은 매개변수로 전달하여 수행하게끔 진행"

        public delegate bool Filtering(User u);
        //      (User u) :: "특정 객체"의 Age값 조회
        //      bool 반환 :: 20세 이상/미만 "인지(true) 아닌지(false)" 반환

        public void print_result(Filtering ft)
        {
            string result = "";
            foreach (var u in user)
            {
                if (ft(u))       // 성인 데이터에 대해 연산할지, 미성년 데이터에 대해 연산할지
                {
                    result += u.Name + " ";
                }
            }

            MessageBox.Show($"필터링 결과: {result}");
        }

        // 객체의 나이 조건문 (20세 이상)
        private void print_adult_Click(object sender, EventArgs e)
        {
            print_result(delegate (User us)
            {
                // "print_result()에서 탐색하고 있는 User 객체의 나이가 20 이상인가"
                //      => true/false를 반환
                return us.Age >= 20;
            });
        }

        // 객체의 나이 조건문 (20세 미만)
        private void pring_kids_Click(object sender, EventArgs e)
        {
            print_result((User us) =>
            {
                return us.Age < 20;
            });
        }
    }
}
