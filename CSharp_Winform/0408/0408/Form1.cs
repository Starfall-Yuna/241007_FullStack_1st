using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0408
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Employee
        {
            public string Name { get; set; }
            public string State { get; set; }
        }
        List<Employee> empList = new List<Employee>()
        {
            new Employee{Name="Lee", State="재직"},
            new Employee{Name="Park", State="퇴사"},
            new Employee{Name="Kim", State="해고"},
            new Employee{Name="Choi", State="재직"},
            new Employee{Name="Cho", State="퇴사"}
        };

        // (매개변수) Employee 객체, (반환형) bool형
        public delegate bool Filtering(Employee em);

        public void print_result(Filtering ft)  // Filtering 형식의 함수 내용을 ft라는 이름으로 받아옴 
        {
            string result = "";
            foreach (var em in empList)
            {
                if (ft(em))   // 두 이벤트의 차이점 => 매개변수로 내용을 받아줄 필요가 있음
                {
                    result += em.Name + Environment.NewLine;
                }
            }
            print_list.Text = result;
        }

        // "재직자 명단" 클릭 시, 라벨에 재직하고 있는 사람의 이름을 추출하여 출력
        //  if (em.State == "재직")
        private void print_ing_Click(object sender, EventArgs e)
        {
            // delegate를 통하여, 함수 내용 보내줌 (판별식)
            print_result(delegate (Employee em)
            {
                return em.State == "재직";
            });
        }

        // "퇴사자 명단" 클릭 시, 라벨에 재직하고 있지 않는 사람의 이름을 추출하여 출력
        // if (em.State != "재직")
        private void print_end_Click(object sender, EventArgs e)
        {
            // 람다식을 통하여, 함수 내용 보내줌 (판별식)
            print_result((Employee em) =>
            {
                return em.State != "재직";
            });
        }

        private void delete_event_Click(object sender, EventArgs e)
        {
            // EventHandler() :: 이벤트 제어하는 함수, 제3의 요소 이벤트 제어 가능
            String text = "이벤트를 삭제합니다." + Environment.NewLine;
            text += "프로그램을 다시 실행해주세요.";
            MessageBox.Show(text);

            print_ing.Click -= new System.EventHandler(print_ing_Click);
            print_end.Click -= new System.EventHandler(print_end_Click);
            print_list.Text = "<명단을 출력할 수 없습니다.>";
        }
    }
}
