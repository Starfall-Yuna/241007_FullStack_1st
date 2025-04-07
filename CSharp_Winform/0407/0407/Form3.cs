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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public delegate int calc(int a, int b);

        // 콜백 메소드 :: 매개변수로 전달되는 메소드
        public void print_calc(int start_num, calc c)
        {
            int num = int.Parse(input_num.Text);
            int result = start_num;     // 0으로 초기화하냐, 1로 초기화하냐

            for (int i = 1; i <= num; i++)
            {
                result = c(result, i);
            }   
            MessageBox.Show($"연산 결과: {result}");
        }

        // 1부터 입력값까지의 덧셈 결과 출력
        // result를 0으로 초기화, for문 안으로 덧셈 수행
        private void execute_plus_Click(object sender, EventArgs e)
        {
            // print_calc() 함수 수행       -> result=0, 덧셈 수행
            print_calc(0, delegate (int a, int b)       // print_calc()의 c 내용으로 전달
            {
                // 반환형 int, 매개변수 구성 (int, int)
                return a + b;
            });
        }
        
        // 1부터 입력값까지의 곱셈 결과 출력
        // result를 1로 초기화, for문 안으로 곱셈 수행
        private void execute_multi_Click(object sender, EventArgs e)
        {
            // print_calc() 함수 수행       -> result=1, 곱셈 수행
            print_calc(1, (int a, int b) =>             // print_calc()의 c 내용으로 전달
            {
                // 반환형 int, 매개변수 구성 (int, int)
                return a * b;
            });
        }
    }
}
