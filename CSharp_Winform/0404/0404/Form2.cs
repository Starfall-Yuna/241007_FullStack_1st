using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0404
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // (5개의 int형 값을 반환하는 사칙연산 함수 구현)
        public int None(int a, int b) { return 0; }
        public int add(int a, int b) { return a + b; }
        public int sub(int a, int b) { return a - b; }
        public int mul(int a, int b) { return a * b; }
        public int div1(int a, int b) { return a / b; }
        public int div2(int a, int b) { return a % b; }

        // Delegate(대리자) :: 메소드를 저장할 수 있는 자료형 생성 키워드
        //      함수의 정보 (반환형, 매개변수 구성, 함수의 내용)
        //      델리게이트 선언에 필요한 내용 (반환형, 매개변수 구성)

        public delegate int calc(int a, int b);
        //      반환형이 int이고 매개변수 구성이 (int, int)인
        //      함수 내용을 저장할 수 있는 자료형 calc 생성
        //      (반환형이나 매개변수 구성이 다르면, 함수 내용 저장에 지장 생김)
        private void ExecuteCalc_Click(object sender, EventArgs e)
        {
            // 2개의 정수값 입력받고
            int n1 = int.Parse(num1.Text);
            int n2 = int.Parse(num2.Text);

            // 체크된 라디오 박스에 대한 연산 결과를 
            calc c;     
                // "반환형 int이고, 매개변수 (int, int)"인 정보를 저장할 수 있는 변수 c
            int result = 0;
            if (plus.Checked == true)           { c = add; }
            else if(minus.Checked == true)      { c = sub; }
            else if(multi.Checked == true)      { c= mul; }
            else if(divide1.Checked == true)    { c = div1; }
            else if(divide2.Checked == true)    { c = div2; }
            else { c = None; }
            // calc에 저장된 내용대로 명령을 수행한 뒤의 반환값을
            // result에 저장
            result = c(n1, n2);
           

            // 메시지 박스로 출력
            MessageBox.Show($"연산 결과: {result}");
        }
    }
}
