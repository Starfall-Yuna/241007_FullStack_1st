using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _0409
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 1. 인터페이스(Message) 작성
        //      - PrintHello() 함수 
        public interface Message
        {
            void PrintHello();
        }

        // 2. 구조체(InOut) 작성 ::
        //      - State 속성 :: "In", "Out" 중 하나 저장
        //      - Time 속성 :: 시스템 시간을 정보로 저장 (DateTime 자료형)
        //      - PrintHello 메소드 ::
        //          State 값이 "In"이면 출근했다는 메시지 출력
        //          State 값이 "Out"이면 퇴근했다는 메시지 출력
        public struct InOut : Message
        {
            public string State { get; set; }
            public DateTime Time { get; set; }

            public void PrintHello()
            {
                string msg = this.Time + Environment.NewLine;
                if(this.State == "In")
                {
                    msg += "출근하였습니다.";
                }
                else
                {
                    msg += "퇴근하였습니다.";
                }

                MessageBox.Show(msg);
            }
        }

        // 딕셔너리 :: Key, Value으로 구성 / Key를 통해서 Value에 접근
        // 3. 빈 딕셔너리(IO)를 선언 (사원의 이름값을 통해서, 구조체 변수에 접근)
        //      "Lee" 라는 이름을 통하여,
        //          {"In", 2025.04.09 09:31}와 메소드에 접근
        Dictionary<string, InOut> IO = new Dictionary<string, InOut>();

        // 4. 출근계 이벤트 작성
        //      - 딕셔너리에 데이터 삽입/수정 (State="In"으로)
        //      - PrintHello() 실행 + 라벨에 딕셔너리 내용 출력
        private void in_button_Click(object sender, EventArgs e)
        {
            string name = name_input.Text;
            // name 공간의 Value값 설정
            //  name 공간이 없었다면, 구조체 변수값 삽입
            //  name 공간이 존재하는 상태였다면, 구조체 변수값으로 값 대체
            IO[name] = new InOut()
            {
                State = "In",
                Time = DateTime.Now     // 현재 시스템 시간 불러오기
            };

            // PrintHello()는 엄연히 Value에 존재 (Key를 통하여 접근)
            IO[name].PrintHello();

            string text = "";
            foreach(KeyValuePair<string, InOut> item in IO)    
            {
                // IO 딕셔너리 데이터를 item을 통해서 <key, value> 형태로 불러옴
                text += item.Key + ": " + item.Value.State + " " + item.Value.Time;
                text += Environment.NewLine;
            }
            list.Text = text;
        }

        // 5. 퇴근계 이벤트 작성
        //      - 딕셔너리에 데이터 삽입/수정 (State="Out"으로)
        //      - PrintHello() 실행 + 라벨에 딕셔너리 내용 출력
        private void out_button_Click(object sender, EventArgs e)
        {
            string name = name_input.Text;
            IO[name] = new InOut()
            {
                State = "Out",
                Time = DateTime.Now
            };

            IO[name].PrintHello();

            string text = "";
            foreach(KeyValuePair<string, InOut> item in IO)
            {
                text += item.Key + ": " + item.Value.State + " " + item.Value.Time;
                text += Environment.NewLine;
            }
            list.Text = text;
        }
    }
}
