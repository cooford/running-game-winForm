namespace WindowsFormsApplication6
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox_human = new System.Windows.Forms.PictureBox();
            this.pictureBox_hurdle = new System.Windows.Forms.PictureBox();
            this.pictureBox_hurdle2 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer_ing = new System.Windows.Forms.Timer(this.components);
            this.label2_ingtime = new System.Windows.Forms.Label();
            this.label_re = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_human)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hurdle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hurdle2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(73, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(384, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(503, 131);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(84, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox_human
            // 
            this.pictureBox_human.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_human.Image")));
            this.pictureBox_human.Location = new System.Drawing.Point(567, 236);
            this.pictureBox_human.Name = "pictureBox_human";
            this.pictureBox_human.Size = new System.Drawing.Size(60, 83);
            this.pictureBox_human.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_human.TabIndex = 4;
            this.pictureBox_human.TabStop = false;
            // 
            // pictureBox_hurdle
            // 
            this.pictureBox_hurdle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_hurdle.Image")));
            this.pictureBox_hurdle.Location = new System.Drawing.Point(402, 287);
            this.pictureBox_hurdle.Name = "pictureBox_hurdle";
            this.pictureBox_hurdle.Size = new System.Drawing.Size(35, 32);
            this.pictureBox_hurdle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_hurdle.TabIndex = 5;
            this.pictureBox_hurdle.TabStop = false;
            // 
            // pictureBox_hurdle2
            // 
            this.pictureBox_hurdle2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_hurdle2.Image")));
            this.pictureBox_hurdle2.Location = new System.Drawing.Point(187, 287);
            this.pictureBox_hurdle2.Name = "pictureBox_hurdle2";
            this.pictureBox_hurdle2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox_hurdle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_hurdle2.TabIndex = 6;
            this.pictureBox_hurdle2.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("굴림", 30F);
            this.label1.Location = new System.Drawing.Point(280, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Start";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer_ing
            // 
            this.timer_ing.Interval = 1000;
            this.timer_ing.Tick += new System.EventHandler(this.timer_ing_Tick);
            // 
            // label2_ingtime
            // 
            this.label2_ingtime.AutoSize = true;
            this.label2_ingtime.BackColor = System.Drawing.Color.GreenYellow;
            this.label2_ingtime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2_ingtime.Font = new System.Drawing.Font("굴림", 30F);
            this.label2_ingtime.Location = new System.Drawing.Point(248, 121);
            this.label2_ingtime.Name = "label2_ingtime";
            this.label2_ingtime.Size = new System.Drawing.Size(179, 42);
            this.label2_ingtime.TabIndex = 9;
            this.label2_ingtime.Text = "게임시간";
            this.label2_ingtime.Visible = false;
            // 
            // label_re
            // 
            this.label_re.AutoSize = true;
            this.label_re.BackColor = System.Drawing.Color.Khaki;
            this.label_re.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_re.Font = new System.Drawing.Font("굴림", 30F);
            this.label_re.Location = new System.Drawing.Point(248, 174);
            this.label_re.Name = "label_re";
            this.label_re.Size = new System.Drawing.Size(179, 42);
            this.label_re.TabIndex = 10;
            this.label_re.Text = "다시하기";
            this.label_re.Visible = false;
            this.label_re.Click += new System.EventHandler(this.label_re_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.label_re);
            this.Controls.Add(this.label2_ingtime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_hurdle2);
            this.Controls.Add(this.pictureBox_hurdle);
            this.Controls.Add(this.pictureBox_human);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_human)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hurdle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hurdle2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox_human;
        private System.Windows.Forms.PictureBox pictureBox_hurdle;
        private System.Windows.Forms.PictureBox pictureBox_hurdle2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_ing;
        private System.Windows.Forms.Label label2_ingtime;
        private System.Windows.Forms.Label label_re;
    }
}

