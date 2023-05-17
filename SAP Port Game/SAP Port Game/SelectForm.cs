using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAP_Port_Game
{
    public partial class SelectForm : Form
    {
        int Count = 0;
        public SelectForm()
        {
            InitializeComponent();
            SetList();
            StartTimer();
        }

        Dictionary<string, string> PortList = new Dictionary<string, string>();

        void SetList()
        {
            PortList.Add("ABAP Dispatcher", "32NN");
            PortList.Add("ABAP GateWay", "33NN");
            PortList.Add("ABAP Message Server", "36NN");
            PortList.Add("ABAP ICM", "80NN");
            PortList.Add("Java Http", "5NN00");
            PortList.Add("Java Https", "5NN01");
            PortList.Add("Java Message Server", "81NN");
            PortList.Add("Java P4", "5NN04");
            PortList.Add("Java Telnet", "5NN08");
            PortList.Add("SAPinst", "21212");
            PortList.Add("SAP MC HTTP", "5NN13");
        }

        int result;
        Button[] buttons = new Button[4];
        void RandomSolution()
        {
            selected = false;
            Random R = new Random(int.Parse(DateTime.Now.Second.ToString()));
            result = R.Next(0, 10);
            lbl_Solution.Text = PortList.ElementAt(result).Key;
            int[] ListValue = new int[4];
            ListValue[0] = result;
            int point = 1;
            int Value = 0;

            while (true)
            {
                Value = R.Next(0, 10);
                if (!ListValue.Contains(Value))
                {
                    ListValue[point] = Value;
                    point++;
                }
                if (point > 3) break;
            }

            buttons[0] = btn_1;
            buttons[1] = btn_2;
            buttons[2] = btn_3;
            buttons[3] = btn_4;

            int[] ListButtons = new int[4] { 10, 10, 10, 10 };
            Random D = new Random(int.Parse(DateTime.Now.Second.ToString()));
            point = 0;
            while (true)
            {
                Value = D.Next(1, 5);
                if (!ListButtons.Contains(Value - 1))
                {
                    ListButtons[point] = Value - 1;
                    point++;
                }
                if (point > 3) break;
            }

            buttons[ListButtons[0]].Text = PortList.ElementAt(ListValue[0]).Value;
            buttons[ListButtons[1]].Text = PortList.ElementAt(ListValue[1]).Value;
            buttons[ListButtons[2]].Text = PortList.ElementAt(ListValue[2]).Value;
            buttons[ListButtons[3]].Text = PortList.ElementAt(ListValue[3]).Value;

            OnButton();
            SetColor();
        }

        string result1;
        string result2;
        private void btn_Click(object sender, EventArgs e)
        {
            result1 = PortList.ElementAt(result).Value.ToString().Trim();
            result2 = sender.ToString().Split(':')[1].ToString().Trim();
            StopTimer();
            if (result1 == result2)
            {
                MessageBox.Show("정답입니다.");
                Count++;
                lbl_Count.Text = "맞춘 개수 : " + Count.ToString();
                OffButton();
            }
            else
            {
                MessageBox.Show("틀렸습니다.\n" + "정답은 " + PortList.ElementAt(result).Value + " 입니다.");
                OffButton();
            }
            ClickColor();
            StartTimer();
        }

        void SetColor()
        {
            foreach (Button button in buttons)
            {
                button.BackColor = Color.WhiteSmoke;
                button.ForeColor = Color.Black;
            }
        }
        void ClickColor()
        {
            selected = true;
            foreach (Button button in buttons)
            {
                if (button.Text == result1)
                {
                    button.BackColor = Color.DarkSeaGreen;
                    button.ForeColor = Color.White;
                }
                else
                {
                    button.BackColor = Color.IndianRed;
                    button.ForeColor = Color.White;
                }
            }
        }

        void OnButton()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }
        }

        void OffButton()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = false;
            }
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {
            RandomSolution();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.FillRectangle(Brushes.Orange, 0, 0, panel1.Width / 100 * (timer1.Interval / 1000), panel1.Height);
        }
        bool selected = false;
        private void StartTimer()
        {
            timer1.Interval = 5000;
            timer1.Enabled = true;
            timer2.Interval = 500;
            timer2.Enabled = true;
            TimerCount = 0;
        }

        private void StopTimer()
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RandomSolution();
        }

        int TimerCount = 0;
        private Font F = new Font("굴림", 9);
        private void timer2_Tick(object sender, EventArgs e)
        {
            TimerCount++;
            
            PaintEventArgs e1 = new PaintEventArgs(panel1.CreateGraphics(), panel1.RectangleToClient(new Rectangle(12, 12, 489, 26)));
            
            Graphics G = e1.Graphics;
            G.Clear(Color.White);
            G.FillRectangle(Brushes.Orange, 0, 0, panel1.Width / 10 * TimerCount, panel1.Height);
            G.DrawString("", F, Brushes.DarkRed, panel1.Width / 2 - 40, panel1.Height / 4);
            if(selected == false)
                G.DrawString("남은 시간 : " + (10 - TimerCount).ToString() + "초", F, Brushes.DarkRed, panel1.Width / 2 - 40, panel1.Height / 4);
            else
                G.DrawString("변경 까지 : " + (10 - TimerCount).ToString() + "초", F, Brushes.DarkRed, panel1.Width / 2 - 40, panel1.Height / 4);
            if (TimerCount == 10)
            {
                TimerCount = 0;
                G.FillRectangle(Brushes.White, 0, 0, panel1.Width, panel1.Height);
            }
        }
    }
}
