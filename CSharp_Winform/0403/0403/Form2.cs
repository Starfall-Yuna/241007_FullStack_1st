using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0403
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Person 클래스 생성 :: 이름, 나이, 성별
        public class Person
        {
            public string name { get; set; }
            public int age { get; set; }
            public string gender { get; set; }
        }
        // Person형의 빈 리스트(pList) 선언     -> 객체 리스트
        List<Person> pList = new List<Person>();


        // "입력" 버튼을 눌렀을 때, 아래의 동작을 하는 이벤트 구현
        private void insert_data_Click(object sender, EventArgs e)
        {
            //  - 3개의 입력에 대해 파싱 진행 (나이는 int로 파싱)
            string n = name_input.Text;
            int a = int.Parse(age_input.Text);
            string g = gender_input.Text;

            //  - PList에 입력값을 기반으로 객체 삽입
            //Person p = new Person();
            //p.name = n;
            //p.age = a;
            //p.gender = g;
            //pList.Add(p);
            pList.Add(new Person { name = n, age = a, gender = g });

            if (a < 20)
            {
                MessageBox.Show("미성년자 데이터는 화면에 출력되지 않습니다.");
            }

            //  - (Linq 활용) pList에서 성인 데이터만 골라서
            //          {이름, 나이, 성별} 묶음 불러오기
            //      <orderby만 작성하면   -> ascending 디폴트 적용(오름차순)>
            var output = from element
                         in pList
                         where element.age >= 20
                         orderby element.age
                         select new
                         {
                             name = element.name,
                             age = element.age,
                             gender = element.gender
                         };     // new 키워드로 익명 객체 생성 -> output으로 전달

            //  - 위에서 조회한 데이터(output)를, 라벨에 출력
            string result = "";
            foreach(var p in output)
            {
                result += "이름: " + p.name + Environment.NewLine;
                result += "나이: " + p.age + Environment.NewLine;
                result += "성별: " + p.gender + Environment.NewLine;
                result += Environment.NewLine;
            }
            print_adult.Text = result;

            // + 입력칸 공란으로 바꾸기
            name_input.Text = "";
            age_input.Text = "";
            gender_input.Text = "";
        }

    }
}
