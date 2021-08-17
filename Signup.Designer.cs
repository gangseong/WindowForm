
namespace MySqlConnect2
{
    partial class Signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.birthbox = new System.Windows.Forms.TextBox();
            this.idbox = new System.Windows.Forms.TextBox();
            this.pwdbox = new System.Windows.Forms.TextBox();
            this.pwdcheckbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.phonecheckbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.phonebox = new System.Windows.Forms.TextBox();
            this.finishbtn = new System.Windows.Forms.Button();
            this.pwdcheckbtn = new System.Windows.Forms.Button();
            this.pcheckbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.phonecheckbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(366, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원가입 창";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(186, 95);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(100, 21);
            this.namebox.TabIndex = 1;
            // 
            // birthbox
            // 
            this.birthbox.ForeColor = System.Drawing.Color.DarkGray;
            this.birthbox.Location = new System.Drawing.Point(186, 159);
            this.birthbox.Multiline = true;
            this.birthbox.Name = "birthbox";
            this.birthbox.Size = new System.Drawing.Size(100, 15);
            this.birthbox.TabIndex = 2;
            this.birthbox.Text = "6자리 입력하세요";
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(186, 220);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(100, 21);
            this.idbox.TabIndex = 3;
            // 
            // pwdbox
            // 
            this.pwdbox.Location = new System.Drawing.Point(186, 279);
            this.pwdbox.Name = "pwdbox";
            this.pwdbox.PasswordChar = '*';
            this.pwdbox.Size = new System.Drawing.Size(100, 21);
            this.pwdbox.TabIndex = 4;
            // 
            // pwdcheckbox
            // 
            this.pwdcheckbox.Location = new System.Drawing.Point(186, 332);
            this.pwdcheckbox.Name = "pwdcheckbox";
            this.pwdcheckbox.PasswordChar = '*';
            this.pwdcheckbox.Size = new System.Drawing.Size(100, 21);
            this.pwdcheckbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "이름 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "생년월일 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "아이디 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "비밀번호 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "비밀번호 확인 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "8자리 이상";
            // 
            // phonecheckbtn
            // 
            this.phonecheckbtn.Location = new System.Drawing.Point(314, 388);
            this.phonecheckbtn.Name = "phonecheckbtn";
            this.phonecheckbtn.Size = new System.Drawing.Size(96, 21);
            this.phonecheckbtn.TabIndex = 15;
            this.phonecheckbtn.Text = "인증번호 발송";
            this.phonecheckbtn.UseVisualStyleBackColor = true;
            this.phonecheckbtn.Click += new System.EventHandler(this.phonecheckbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "휴대번호 :";
            // 
            // phonebox
            // 
            this.phonebox.Location = new System.Drawing.Point(186, 388);
            this.phonebox.Name = "phonebox";
            this.phonebox.Size = new System.Drawing.Size(122, 21);
            this.phonebox.TabIndex = 6;
            // 
            // finishbtn
            // 
            this.finishbtn.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.finishbtn.Location = new System.Drawing.Point(370, 481);
            this.finishbtn.Name = "finishbtn";
            this.finishbtn.Size = new System.Drawing.Size(126, 38);
            this.finishbtn.TabIndex = 16;
            this.finishbtn.Text = "완료";
            this.finishbtn.UseVisualStyleBackColor = true;
            this.finishbtn.Click += new System.EventHandler(this.finishbtn_Click);
            // 
            // pwdcheckbtn
            // 
            this.pwdcheckbtn.Location = new System.Drawing.Point(314, 330);
            this.pwdcheckbtn.Name = "pwdcheckbtn";
            this.pwdcheckbtn.Size = new System.Drawing.Size(75, 23);
            this.pwdcheckbtn.TabIndex = 17;
            this.pwdcheckbtn.Text = "체크";
            this.pwdcheckbtn.UseVisualStyleBackColor = true;
            this.pwdcheckbtn.Click += new System.EventHandler(this.pwdcheckbtn_Click);
            // 
            // pcheckbtn
            // 
            this.pcheckbtn.Location = new System.Drawing.Point(314, 442);
            this.pcheckbtn.Name = "pcheckbtn";
            this.pcheckbtn.Size = new System.Drawing.Size(96, 21);
            this.pcheckbtn.TabIndex = 18;
            this.pcheckbtn.Text = "인증번호 확인";
            this.pcheckbtn.UseVisualStyleBackColor = true;
            this.pcheckbtn.Click += new System.EventHandler(this.pcheckbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "기호없이 작성해주세요";
            // 
            // phonecheckbox
            // 
            this.phonecheckbox.Location = new System.Drawing.Point(186, 441);
            this.phonecheckbox.Name = "phonecheckbox";
            this.phonecheckbox.Size = new System.Drawing.Size(100, 21);
            this.phonecheckbox.TabIndex = 20;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 553);
            this.Controls.Add(this.phonecheckbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pcheckbtn);
            this.Controls.Add(this.pwdcheckbtn);
            this.Controls.Add(this.finishbtn);
            this.Controls.Add(this.phonecheckbtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phonebox);
            this.Controls.Add(this.pwdcheckbox);
            this.Controls.Add(this.pwdbox);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.birthbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label1);
            this.Name = "Signup";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox birthbox;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.TextBox pwdbox;
        private System.Windows.Forms.TextBox pwdcheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button phonecheckbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phonebox;
        private System.Windows.Forms.Button finishbtn;
        private System.Windows.Forms.Button pwdcheckbtn;
        private System.Windows.Forms.Button pcheckbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phonecheckbox;
    }
}