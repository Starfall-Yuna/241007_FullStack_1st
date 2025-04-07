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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // 델리게이트 :: 함수를 저장할 수 있게끔 자료형 선언
        //          [1] 함수 내용을 저장할 수 있는 변수 선언 & 함수 내용 저장
        //          [2] 함수의 내용을 즉시 작성해서 넘겨주는 역할

        public delegate void PrintAnything();

        private void button1_Click(object sender, EventArgs e)
        {
            // 무명 델리게이트 :: delegate 키워드를 통하여 만든 이름없는 메소드
            //      선언부에 있는 동일한 반환형-매개변수 구성의 중복 작성 방지

            // delegate 키워드로, 함수 선언
            // hello :: (반환형)void, (매개변수)없음
            PrintAnything hello = delegate ()
            {
                MessageBox.Show("안녕하세요!!!");
            };

            // 람다식 :: 무명 delegate 작성을 축약
            //      ( delegate 키워드 대신 => 활용 )
            // print :: (반환형)void, (매개변수)없음
            PrintAnything print = () =>
            {
                MessageBox.Show("테스트용입니다");
            };

            // 위에서 선언한 함수 실행
            hello();
            print();

            // 이미 선언된 변수에 대해, 함수 내용 변경
            //int num = 5;
            //num = 10;
            print = () => { MessageBox.Show("변경된 내용입니다."); };
            print();
        }
    }
}
