using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0407
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1) Upper() 함수 구현 :: 매개변수로 받은 string형을 대문자로 변환
        public string Upper(string target)
        {
            //char[] chars = target.ToCharArray();
            //for (int i = 0; i < target.Length; i++)
            //{
            //    if ('a' <= target[i] && target[i] <= 'z')
            //    {
            //        chars[i] = (char)(chars[i] - 32);
            //    }
            //}

            //return new string(chars);

            return target.ToUpper();
        }

        // 2) Lower() 함수 구현 :: 매개벼수로 받은 string형을 소문자로 변환
        public string Lower(string target)
        {
            return target.ToLower();
        }

        // 3) AsciiSum() 함수 구현
        public int AsciiSum(string target)
        {
            int sum = 0;
            foreach (char c in target)  // c :: target의 문자 하나하나 
            {
                sum += c;
            }
            return sum;
        }

        // 3) 아래처럼 델리게이트 선언 + 델리게이트에 따른 변수 선언
        // 델리게이트 :: 함수의 내용을 저장할 수 있게끔 자료형 선언
        //      델리게이트를 통한 자료형으로 함수를 저장할 수 있는 변수 선언
        public delegate string revert(string target);
        revert func;

        // func을 통해서 저장 가능한 함수 :: Upper(), Lower()

        // 4) "대문자로", "소문자로" 버튼에 대한 이벤트 생성
        //      - 델리게이트를 통해서, Upper() 및 Lower() 함수 실행
        //      - 각 함수의 결과물을 mbox로 출력
        private void revert_upper_Click(object sender, EventArgs e)
        {
            // 1] 입력값 불러오기
            string input = input_string.Text;

            // 2] input에 대하여, 대문자 변동 작업 진행
            func = Upper;
            string result = func(input);    // Upper() 함수 간접적으로 실행

            // 3] 결과값을 mbox로 출력
            MessageBox.Show($"대문자로 변환: {result}");
        }

        private void revert_lower_Click(object sender, EventArgs e)
        {
            // 1] 입력값 불러오기
            string input = input_string.Text;

            // 2] input에 대하여, 소문자 변동 작업 진행
            func = Lower;
            string result = func(input);    // Lower() 함수 간접적으로 실행

            // 3] 결과값을 mbox로 출력
            MessageBox.Show($"소문자로 변환: {result}");
        }

        private void sum_Click(object sender, EventArgs e)
        {
            // 1] 입력값 불러오기
            string input = input_string.Text;

            // 2] input에 대하여, 아스키코드 값의 합 구하기
            // func = AsciiSum;    // func 형식과 AsciiSum 형식이 다름
            int result = AsciiSum(input);

            // 3] 결과값을 mbox로 출력
            MessageBox.Show($"아스키코드 합 결과: {result}");
        }
    }
}
