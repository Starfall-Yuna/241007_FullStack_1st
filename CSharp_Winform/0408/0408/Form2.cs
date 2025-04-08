using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _0408
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public interface XY
        {
            void setInfo(int x, int y, string l);
            void setQuad();
        }

        // 구조체(struct) :: 클래스와 유사
        //      접근제어자 활용, 속성/필드 및 메소드 추가 가능
        //      "인터페이스 상속" 가능 + 다중 상속 지원
        //      추상클래스, 일반적인 상속 불가능
        public struct XYstruct : XY, IComparable<XYstruct>
        {
            public int x { get; set; }
            public int y { get; set; }
            public int quad { get; set; }
            public string location { get; set; }

            // CompareTo() 메소드를 불러온 객체 - 그 이외의 다른 객체(매개변수)
            //      => 서로서로 비교를 수행하는 메소드
            // (List) Sort() 실행할 때, CompareTo() 메소드를 자동 참조

            // x 좌표를 기준으로 우선적으로 오름차순 정렬
            // 만약 x 좌표가 같은 경우엔, y 좌표를 기준으로 오름차순 정렬
            public int CompareTo(XYstruct other)
            {
                // CompareTo() :: 현재 객체 x값이 작으면 -1 반환, 같으면 0, 크면 1 반환
                if(x.CompareTo(other.x) == 0)
                {
                    return y.CompareTo(other.y);
                }
                return x.CompareTo(other.x);
            }

            // 인터페이스 상속받아서, 메소드 구현
            // 1. setInfo() :: 속성(x, y, location)값 초기화
            public void setInfo(int x, int y, string l)
            {
                this.x = x;
                this.y = y;
                this.location = l;
            }
            // 2. setQuad() ::
            //     x, y값에 따라서, quad값 설정 + 사분면 mbox로 출력
            //      - x나 y 둘 중 하나가 0이라면, "x축 또는 y축에 있습니다." 출력
            public void setQuad()
            {
                if (x > 0 && y > 0) { quad = 1; }
                else if (x < 0 && y > 0) { quad = 2; }
                else if (x < 0 && y < 0) { quad = 3; }
                else if (x > 0 && y < 0) { quad = 4; }
                else { quad = 0; }

                if (quad == 0)
                {
                    MessageBox.Show("X축 또는 Y축에 있습니다.");
                }
                else
                {
                    MessageBox.Show($"{this.quad}사분면에 있습니다.");
                }
            }
        }
        List<XYstruct> xyList = new List<XYstruct>();

        private void insert_xy_Click(object sender, EventArgs e)
        {
            // 1] 입력값 불러오기
            int x = int.Parse(text_x.Text);
            int y = int.Parse(text_y.Text);
            string loca = text_loca.Text;

            // 2] 메소드 실행 + 리스트에 요소 삽입
            XYstruct test = new XYstruct();
            test.setInfo(x, y, loca);
            test.setQuad();
            xyList.Add(test);
            xyList.Sort();      // Sort() 수행할 때, CompareTo() 함수 활용

            // 3] 라벨에 리스트 요소 출력
            string result = "";
            foreach(var item in xyList)
            {
                result += "x좌표: " + item.x + Environment.NewLine;
                result += "y좌표: " + item.y + Environment.NewLine;
                result += item.location + Environment.NewLine;
                result += Environment.NewLine;
            }
            print_xy.Text = result;
        }
    }
}
