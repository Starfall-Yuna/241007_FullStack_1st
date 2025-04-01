using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 구성 요소들을 컴포넌트/컨트롤로 부름

namespace _0401
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 이벤트 :: 사용자 행위에 따라 수행되는 기능(메소드)
        // 컴포넌트를 더블 클릭하면, 그에 따른 이벤트 메소드 자동 생성
        // "요소의 이벤트 아이콘 클릭하면, 이벤트랑 관련된 정보 확인"

        // object sender :: 이벤트 발생시키는 요소 (이 메소드 경우에는 "버튼")
        // EventArgs e :: 이벤트와 연관된 정보 담고있음
        private void 버튼_Click(object sender, EventArgs e)
        {
            // 모달 :: 코드 실행이 멈추고 + 특정 창에 포커싱 고정
            // 메시지 박스 :: 모달의 일종, 간단한 창 띄우는 용도
            MessageBox.Show("버튼을 클릭하였습니다.");

            // 모달리스 :: 코드 실행 그대로 수행 + 뒤에 있는 창에도 포커싱 맞출 수 있음
            //      별도의 Form을 따로 구현해야 함
        }

        private void calc_button_Click(object sender, EventArgs e)
        {
            // 1. 2개의 입력값을 double형으로 파싱 진행
            double number1 = double.Parse(num1.Text);
            double number2 = double.Parse(num2.Text);

            // 2. 선택한 라디오 버튼에 따라, 그에 맞는 연산 수행
            //      + 연산 결과값을 메시지 박스로 출력
            if (plus.Checked == true)    // "덧셈" 라디오버튼에 체크되어 있다면
            {
                MessageBox.Show($"덧셈 결과: {number1 + number2}");
            }
            else if (sub.Checked == true)
            {
                MessageBox.Show($"뺄셈 결과: {number1 - number2}");
            }
            else if(multi.Checked == true)
            {
                MessageBox.Show($"곱셈 결과: {number1 * number2}");
            }
            else
            {
                MessageBox.Show("수행할 연산자를 선택해주세요.");
            }
        }
    }
}
