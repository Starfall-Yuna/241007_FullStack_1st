using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

// 컴포넌트 :: 도구 상자에서 끌어다 쓰면 됌

namespace _0402
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 이벤트 메소드 :: 사용자 행위에 대한 동작 정의
        private void ExecuteCalc_Click(object sender, EventArgs e)
        {
            // 1. 2개의 숫자를 int형으로 파싱
            int num1 = int.Parse(InputNum1.Text);
            int num2 = int.Parse(InputNum2.Text);

            // 2. 선택한 사칙연산 모두 수행
            string result = "";
            if(plus.Checked == true)
            {
                // Environment.NewLine :: '\n'과 동일
                result += "덧셈 결과: " + (num1 + num2) + Environment.NewLine;
            }
            if(sub.Checked == true)
            {
                result += "뺄셈 결과: " + (num1 - num2) + Environment.NewLine;
            }
            if (multi.Checked == true)
            {
                result += "곱셈 결과: " + (num1 * num2) + Environment.NewLine;
            }
            if (division.Checked == true)
            {
                // 예외 :: 프로그램의 갑작스럽게 종료 증상 (비정상 종료)
                // try - catch - finally

                // num1/num2 예외 발생 가능성 있음 (num2 = 0인 경우)
                bool tf = true;     // tf :: 나눗셈이 정상적으로 수행되었는가?
                try
                {
                    // try :: "우선은 실행해본다"
                    result += "나눗셈 결과: " + (num1 / num2) + Environment.NewLine;
                }
                catch (Exception ex) 
                {
                    // DivideByZeroException :: 값을 0으로 나누려할 때 생기는 예외
                    // IndexOutOfBoundException, FormatException, ...

                    // 지정된 예외가 발생하였을 경우, catch 구문을 옴
                    result += "0으로 나눌 수 없습니다.";
                    tf = false;

                    MessageBox.Show(ex.Message);        // 예외 내용
                    MessageBox.Show(ex.StackTrace);     // 예외 발생할 위치
                }
                finally
                {
                    // try를 정상 실행하여도, 예외로 인하여 catch 구문으로 빠져도
                    // finally는 무조건 실행 (필수적인 사항X)
                    MessageBox.Show($"나눗셈 정상 종료 여부: {tf}");
                }
            }

            if (result == "")
            {
                MessageBox.Show("연산자가 선택되지 않았습니다.");
            }
            else
            {
                MessageBox.Show(result);
            }
        }
    }
}
