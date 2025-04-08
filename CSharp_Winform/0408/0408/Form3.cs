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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }



        // "좌표 이동"에 대한 이벤트 생성
        // 입력된 x값과 y값에 대하여,
        // "요소" 라벨을 이동하기
        //      => (요소 이름).Location 통해 좌표값 설정 가능
        //      => new Point(int, int) 구조체 활용하기
        private void location_button_Click(object sender, EventArgs e)
        {
            // 1] 입력된 x값과 y값 불러오기
            int x = int.Parse(input_x.Text);
            int y = int.Parse(input_y.Text);

            // 2] 요소 이동
            element.Location = new Point(x, y);
            MessageBox.Show($"요소를 ({x}, {y}) 좌표로 이동하였습니다.");
        
            // (0, 0) 좌표 :: 윈폼의 가장 왼쪽이자 가장 위쪽의 모서리 부분
            // Point()의 첫번째 매개변수로 양수값 주면, 오른쪽으로 이동
            // Point()의 두번째 매개변수로 양수값 주면, 아래쪽으로 이동 
            //      양수로 값을 주어야 확인 가능
        }
    }
}
