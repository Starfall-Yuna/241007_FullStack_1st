using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _0409
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // 스레드 :: 프로그램(프로세스)에서 수행하는 작은 단위의 작업
        //      => Thread 키워드를 통해서 생성 가능
        //      => 비동기식으로 작동 (여러 작업을 동시에 처리)
        private void button1_Click(object sender, EventArgs e)
        {
            // 스레드(작업) 생성

            // CrossThread 문제 발생할 수 있는 코드
            //  => UI 스레드와 별도의 스레드가 충돌하여 생기는 문제
            //      - UI 스레드 :: 특정 UI가 자체적으로 가짐 (라벨 자체적으로 작업 수행)
            //      - 별도의 스레드 :: 제3의 요소가 관여 (버튼이 라벨에 간섭)
            Thread t1 = new Thread(() =>
            {
                for(int i=0; i < 100; i++)
                {
                    label1.Text += "A";
                }
            });
            Thread t2 = new Thread(() =>
            {
                for(int i=0; i < 100; i++)
                {
                    label1.Text = "B";
                }
            });

            // 스레드 실행
            t1.Start();
            t2.Start();
            // => 라벨에서 수행하는 스레드 :: 자체적인 UI 스레드 + t1 스레드 + t2 스레드
            // => 정상 실행될 수도 있지만, 비정상 종료가 될 수도 있음
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // CrossThread 방지
            Thread t1 = new Thread(() =>
            {
                for(int i=0; i < 100; i++)
                {
                    // 다른 스레드에서 label1을 건드리는지에 대해,
                    //      for문으로 인하여 100번 체크
                    if (label1.InvokeRequired)
                    {
                        // label1의 자체 스레드를 호출하여, 작업 수행 (t1을 통해서 수행X)
                        // label1 요소를 직접 호출하여, 원하는 동작 수행
                        label1.Invoke(new Action(() =>
                        {
                            label1.Text += "A";
                        }));
                    }
                    else
                    {
                        // 스레드 t1을 통해서, label1에 대해 작업 수행
                        label1.Text += "A";
                    }

                    // Sleep() :: 스레드 수행을 지연 역할 (1000 -> 1초)
                    //  "A"를 Text에 하나 추가하는 데에, 0.01초의 지연을 두게 한다.
                    Thread.Sleep(10);
                }
            });

            Thread t2 = new Thread(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    if (label1.InvokeRequired)
                    {
                        label1.Invoke(new Action(() =>
                        {
                            label1.Text += "B";
                        }));
                    }
                    else
                    {
                        label1.Text += "B";
                    }

                    // "B"를 Text에 하나 추가할때마다 0.01초의 지연 두게 함
                    Thread.Sleep(10);
                }
            });

            t1.Start();
            t2.Start();
        }
    }
}
