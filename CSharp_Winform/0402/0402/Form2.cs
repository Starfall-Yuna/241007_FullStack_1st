using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0402
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();  
        }

        // int형 숫자 저장할 빈 리스트(nList) 선언
        List<int> nList = new List<int>();

        // "숫자 추가" 버튼 누를 때 이벤트 생성
        private void add_number_Click(object sender, EventArgs e)
        {
            // 입력값 int형으로 파싱하여, nList에 삽입  => 예외처리 진행
            // "표시될 공간" 라벨에 nList의 숫자들 순서대로 띄우기
            int n;
            try
            {
                n = int.Parse(number.Text);
                nList.Add(n);

                // "item이란 이름으로 nList의 요소들에 하나씩 접근할 때"
                // item의 값들을 하나씩 조회
                var output = from item
                             in nList
                             select item;

                string result = "";
                foreach (var item in output)  // output 요소를 item으로 순차 접근
                {
                    result += item + Environment.NewLine;
                }
                print_number.Text = result;

                number.Text = "";
            }
            catch(FormatException ex)
            {
                string msg = "";
                msg += ex.Message + Environment.NewLine;
                msg += ex.StackTrace;
                MessageBox.Show(msg);
            }
        }


        // "덧셈 결과" 버튼 누를 때 이벤트 생성
        //    nList의 0번 공간부터 입력된 공간까지(for) 덧셈 진행  => 예외처리 진행
        //    덧셈 결과 메시지 박스로 띄우기

        // 예외처리 진행할 시, 한 창에 예외 내용과 예외발생 위치 출력하기
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                int end_index = int.Parse(select_index.Text);
                int sum = 0;
                for (int i = 0; i < end_index; i++) 
                {
                    sum += nList[i];
                }
                MessageBox.Show($"처음부터 지정된 곳까지의 합: {sum}");

                select_index.Text = "";
            }
            catch (ArgumentOutOfRangeException ex)     // 리스트에 있어서 바깥 영역에 접근
            {
                string result = "";
                result += ex.Message + Environment.NewLine;
                result += ex.StackTrace;
                MessageBox.Show(result);
            }
            catch (FormatException ex)          // 포맷 진행 시 문제가 생김 
            {
                string msg = "";
                msg += ex.Message + Environment.NewLine;
                msg += ex.StackTrace;
                MessageBox.Show(msg);
            }
        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
