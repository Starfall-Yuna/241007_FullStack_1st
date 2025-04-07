using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _0404
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 표와 차트에 활용할 클래스 User
        public class User
        {
            public string name { get; set; }
            public bool answer { get; set; }
        }
        // 표와 차트에 활용할 데이터를 저장할 공간 선언
        // (BindingList :: 표와 자동으로 갱신하면서 연동 가능한 리스트)
        BindingList<User> uList = new BindingList<User>();
        private void Form1_Load(object sender, EventArgs e)
        {
            // 표에 실질적인 데이터를 연결
            dataGridView1.DataSource = uList;
        }

        private void insert_data_Click(object sender, EventArgs e)
        {
            // 1. 입력값 받아오기 & 파싱
            string n = name_input.Text;
            bool a = tf_input.Checked == true ? true : false;

            // 2. 입력값 기반으로 임의의 객체 생성 & 리스트에 삽입
            User u = new User();
            u.name = n;
            u.answer = a;
            uList.Add(u);
            // 여기까지 왔다면, 리스트 최신 정보를 표에 자동으로 넘겨줌

            // Linq를 활용해서 구문 작성
            // yes :: uList 데이터 중에서, answer가 true인 데이터 추출
            var yes = from element
                      in uList
                      where element.answer == true
                      select element;
            // no :: uList 데이터 중에서, answer가 false인 데이터 추출
            var no = from element
                     in uList
                     where element.answer == false
                     select element;

            // 기존 차트의 데이터 초기화 
            chart1.Series.Clear();
            // "답변 결과" 라는 항목 추가 (도넛 타입)
            chart1.Series.Add(new Series("답변 결과") { ChartType = SeriesChartType.Doughnut });

            if (yes.Count() > 0)
            {
                // "예"라고 답변한 유저의 인원수 (yes에 담겨있는 데이터 개수)
                chart1.Series[0].Points.AddXY("예", yes.Count());
            }
            if (no.Count() > 0)
            {
                // "아니오"라고 답변한 유저의 인원수
                chart1.Series[0].Points.AddXY("아니오", no.Count());
            }
        }

    }
}
