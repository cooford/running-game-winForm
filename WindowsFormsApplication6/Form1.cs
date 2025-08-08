using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication6
{
   
    public partial class Form1 : Form
    {
        double a = 0.0; //점프지속시간     
        int gametime = 0; //게임지속시간

        public Form1()
        {
            InitializeComponent();
        }

        void cloud(int speed) //구름이동
        {
            if (pictureBox2.Left >= 700)
                pictureBox2.Left = 0;
            else
                pictureBox2.Left += speed;

            if (pictureBox3.Left >= 700)
                pictureBox3.Left = 0;
            else
                pictureBox3.Left += speed;

            if (pictureBox4.Left >= 700)
                pictureBox4.Left = 0;
            else
                pictureBox4.Left += speed;

        }

        Random r = new Random();
        int x;

        void hurdle(int speed) //장애물 생성
        {
            if (pictureBox_hurdle.Left >= 700)
            {
                x = r.Next(90, 150);
                pictureBox_hurdle.Location = new Point(x, 290);
            }
            else
            {
                pictureBox_hurdle.Left += speed;
            }

            if (pictureBox_hurdle2.Left >= 700)
            {
                x = r.Next(0, 50);
                pictureBox_hurdle2.Location = new Point(x, 290);
            }
            else
            {
                pictureBox_hurdle2.Left += speed;
            }



        }
   
        void end() //장애물에 부딪히는 경우  
        {
                  
            if (pictureBox_human.Bounds.IntersectsWith(pictureBox_hurdle.Bounds))
            {
                timer1.Enabled = false; //배경멈추기            
                label2_ingtime.Visible = true; //게임 지속 시간 창 띄우기
                label2_ingtime.Text = gametime + "초 성공"; //지속시간 알리기
                gametime = 0; //지속시간 리셋
                timer_ing.Enabled = false;  //지속시간 세기 중단
                label_re.Visible = true; //다시하기 버튼 보이게

            }
            if (pictureBox_human.Bounds.IntersectsWith(pictureBox_hurdle2.Bounds))
            {
                timer1.Enabled = false;   //배경멈추기 
                label2_ingtime.Visible = true;  //게임 지속 시간 창 띄우기
                label2_ingtime.Text = gametime + "초 성공";   //지속시간 알리기
                gametime = 0;   //지속시간 리셋
                timer_ing.Enabled = false;   //지속시간 세기 중단
                label_re.Visible = true; //다시하기 버튼 보이게

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            cloud(5);
            hurdle(3);
            end();
         
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) //캐릭 키설정
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pictureBox_human.Left > 0)
                    pictureBox_human.Left += -5;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (pictureBox_human.Right < 700 - pictureBox_human.Width / 2)
                    pictureBox_human.Left += 5;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) //점프 설정
        {
       
           if(e.KeyChar == (char)Keys.Space) //스페이스바가 입력되면
            {
                if (timer2.Enabled == false) //점프 한번만 가능
                {
                    pictureBox_human.Top += -35;
                    
                    timer2.Start(); //점프시간 측정
                }

            }
                         
        }
        
        private void timer2_Tick(object sender, EventArgs e) //점프후 내려오기
        {
            
            a+=0.5;
            if (a == 0.5) //점프후 내려가기
            {
                pictureBox_human.Top += 35;
                a = 0.0;               
                timer2.Enabled = false; //점프타이머 끄기
  
            }
        
        }
      
        private void label1_Click(object sender, EventArgs e)  // 시작버튼을 누른 경우
        {
            timer1.Enabled = true; //배경 움직이기
            label1.Visible = false; //게임시작버튼 안보이게
            timer_ing.Enabled = true;//게임지속 시간측정
    
    
        }

        private void timer_ing_Tick(object sender, EventArgs e) //게임지속시간 세기
        {
            gametime++; //1초씩 증가
            
        }

        private void label_re_Click(object sender, EventArgs e) //다시하기 버튼 누른 경우
        {
   
            pictureBox_hurdle.Location = new Point(0, 290); //장애물 재배치                    
            pictureBox_hurdle2.Location = new Point(300, 290);
         
            label_re.Visible = false; //다시하기 버튼 안보이게
            label2_ingtime.Visible= false; //게임 지속시간 창 안보이게
           
            label1.Visible = true; //시작버튼 보이게            
        }
    }
}
