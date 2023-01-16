
namespace OtomasyonGorselProgProje
{
    partial class Form1
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
            this.markaLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kulLb = new System.Windows.Forms.TextBox();
            this.pasLB = new System.Windows.Forms.TextBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // markaLB
            // 
            this.markaLB.AutoSize = true;
            this.markaLB.BackColor = System.Drawing.Color.Transparent;
            this.markaLB.Font = new System.Drawing.Font("Segoe Script", 22F, System.Drawing.FontStyle.Bold);
            this.markaLB.ForeColor = System.Drawing.Color.White;
            this.markaLB.Location = new System.Drawing.Point(359, 9);
            this.markaLB.Name = "markaLB";
            this.markaLB.Size = new System.Drawing.Size(275, 50);
            this.markaLB.TabIndex = 0;
            this.markaLB.Text = "YUDUM EMLAK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(236, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Girişi ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(364, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(380, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Passaword :";
            // 
            // kulLb
            // 
            this.kulLb.Location = new System.Drawing.Point(492, 138);
            this.kulLb.Name = "kulLb";
            this.kulLb.Size = new System.Drawing.Size(100, 20);
            this.kulLb.TabIndex = 4;
            // 
            // pasLB
            // 
            this.pasLB.Location = new System.Drawing.Point(492, 199);
            this.pasLB.Name = "pasLB";
            this.pasLB.PasswordChar = '*';
            this.pasLB.Size = new System.Drawing.Size(100, 20);
            this.pasLB.TabIndex = 5;
            // 
            // girisBtn
            // 
            this.girisBtn.BackColor = System.Drawing.Color.Transparent;
            this.girisBtn.BackgroundImage = global::OtomasyonGorselProgProje.Properties.Resources.arkaplan;
            this.girisBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.girisBtn.Location = new System.Drawing.Point(374, 282);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(112, 47);
            this.girisBtn.TabIndex = 6;
            this.girisBtn.Text = "Giriş";
            this.girisBtn.UseVisualStyleBackColor = false;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::OtomasyonGorselProgProje.Properties.Resources.arkaplan;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(492, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kayıt Ol";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.girisBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OtomasyonGorselProgProje.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(902, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.pasLB);
            this.Controls.Add(this.kulLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.markaLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label markaLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kulLb;
        private System.Windows.Forms.TextBox pasLB;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Button button1;
    }
}

