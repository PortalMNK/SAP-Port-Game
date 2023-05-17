namespace SAP_Port_Game
{
    partial class SelectForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Solution = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 26);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Solution
            // 
            this.lbl_Solution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Solution.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Solution.Location = new System.Drawing.Point(0, 0);
            this.lbl_Solution.Name = "lbl_Solution";
            this.lbl_Solution.Size = new System.Drawing.Size(489, 50);
            this.lbl_Solution.TabIndex = 1;
            this.lbl_Solution.Text = "Loading";
            this.lbl_Solution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_Solution);
            this.panel2.Location = new System.Drawing.Point(12, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 50);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_4);
            this.panel3.Controls.Add(this.btn_3);
            this.panel3.Controls.Add(this.btn_2);
            this.panel3.Controls.Add(this.btn_1);
            this.panel3.Location = new System.Drawing.Point(12, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 45);
            this.panel3.TabIndex = 3;
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(380, 0);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(110, 45);
            this.btn_4.TabIndex = 3;
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(255, 0);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(110, 45);
            this.btn_3.TabIndex = 2;
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(125, 0);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(110, 45);
            this.btn_2.TabIndex = 1;
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(0, 0);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(110, 45);
            this.btn_1.TabIndex = 0;
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Count.Location = new System.Drawing.Point(14, 148);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(77, 17);
            this.lbl_Count.TabIndex = 4;
            this.lbl_Count.Text = "맞춘 개수 :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(514, 170);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SelectForm";
            this.Text = "Select Port";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Solution;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

