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
    public partial class Form1 : Form
    {
        // 예외 :: 프로그램이 갑작스럽게 종료 증상 (비정상 종료)
        // try - catch - finally :: 예외 처리에 활용

        // Linq :: 컬렉션 데이터 조회 sql문처럼 진행하는 문법
        
        public Form1()
        {
            InitializeComponent();
        }

        List<string> calcList = new List<string>();

        private void ExecuteCalc_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. 2개의 입력값을 int형으로 파싱
                int n1 = int.Parse(input_num1.Text);
                int n2 = int.Parse(input_num2.Text);
                // 파싱 실패하면, try 구문 종료 + FormatException catch로 이동

                // 2. 나눗셈 결과를 메시지 박스에 출력
                MessageBox.Show($"나눗셈 몫 결과: {n1 / n2}");
                // 0으로 나누려할 때, try 구문 종료 + DivideByZeroException catch로 이동

                // 3. 나눗셈 식 string형으로 구성 + 리스트에 추가
                string sentence = n1 + " / " + n2 + " = " + (n1 / n2);
                calcList.Add(sentence);

                // 4. Linq 구문을 통해서, 리스트 데이터 조회
                var output = from item
                             in calcList
                             select item;
                // "calcList의 요소를 item이란 이름으로 하나씩 탐색, 값을 그대로 가져온다"
                //      select문을 마지막에 작성

                // 5. output을 기반으로, label에 표현할 텍스트 구성
                string result = "";
                foreach( var element in output )
                {
                    result += element + Environment.NewLine;
                }

                // 6. 작성된 텍스트를 라벨에 적용 + 입력칸 비우기
                print_calc.Text = result;
                input_num1.Text = "";
                input_num2.Text = "";
            }
            catch(FormatException)
            {
                MessageBox.Show("정수형을 입력해주시길 바랍니다.");
            }
            catch(DivideByZeroException ex)
            {
                string error = ex.Message + Environment.NewLine;    // 에러 내용
                error += ex.StackTrace;      // 에러 발생한 위치
                MessageBox.Show(error);
            }
            finally
            {
                // try를 정상 실행해도, catch구문으로 예외 처리가 되어도
                // finally에 있는 내용은 무조건 실행
                MessageBox.Show("나눗셈 실행을 시도해보았습니다.");
            }
        }
    }
}
