namespace NguyenNhoTu_32_ThiCSharp
{
    partial class Định_dang
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtlaptrinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkBlod = new System.Windows.Forms.CheckBox();
            this.chkchan = new System.Windows.Forms.CheckBox();
            this.chkitalic = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radred = new System.Windows.Forms.RadioButton();
            this.radgreen = new System.Windows.Forms.RadioButton();
            this.radblack = new System.Windows.Forms.RadioButton();
            this.radblue = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnhapten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(161, 363);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtlaptrinh
            // 
            this.txtlaptrinh.Location = new System.Drawing.Point(161, 328);
            this.txtlaptrinh.Name = "txtlaptrinh";
            this.txtlaptrinh.Size = new System.Drawing.Size(155, 20);
            this.txtlaptrinh.TabIndex = 1;
            this.txtlaptrinh.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lập trình bởi";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkBlod
            // 
            this.chkBlod.AutoSize = true;
            this.chkBlod.ForeColor = System.Drawing.Color.Blue;
            this.chkBlod.Location = new System.Drawing.Point(22, 33);
            this.chkBlod.Name = "chkBlod";
            this.chkBlod.Size = new System.Drawing.Size(111, 28);
            this.chkBlod.TabIndex = 0;
            this.chkBlod.Text = "Đậm Blod";
            this.chkBlod.UseVisualStyleBackColor = true;
            this.chkBlod.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkchan
            // 
            this.chkchan.AutoSize = true;
            this.chkchan.ForeColor = System.Drawing.Color.Blue;
            this.chkchan.Location = new System.Drawing.Point(22, 104);
            this.chkchan.Name = "chkchan";
            this.chkchan.Size = new System.Drawing.Size(121, 28);
            this.chkchan.TabIndex = 0;
            this.chkchan.Text = "Gạch chân";
            this.chkchan.UseVisualStyleBackColor = true;
            this.chkchan.CheckedChanged += new System.EventHandler(this.chkchan_CheckedChanged);
            // 
            // chkitalic
            // 
            this.chkitalic.AutoSize = true;
            this.chkitalic.ForeColor = System.Drawing.Color.Blue;
            this.chkitalic.Location = new System.Drawing.Point(22, 70);
            this.chkitalic.Name = "chkitalic";
            this.chkitalic.Size = new System.Drawing.Size(143, 28);
            this.chkitalic.TabIndex = 0;
            this.chkitalic.Text = "Nghiêng Italic";
            this.chkitalic.UseVisualStyleBackColor = true;
            this.chkitalic.CheckedChanged += new System.EventHandler(this.chkitalic_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.chkitalic);
            this.groupBox2.Controls.Add(this.chkchan);
            this.groupBox2.Controls.Add(this.chkBlod);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(287, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 189);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // radred
            // 
            this.radred.AutoSize = true;
            this.radred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radred.Location = new System.Drawing.Point(19, 32);
            this.radred.Name = "radred";
            this.radred.Size = new System.Drawing.Size(63, 28);
            this.radred.TabIndex = 3;
            this.radred.TabStop = true;
            this.radred.Text = "Red";
            this.radred.UseVisualStyleBackColor = true;
            this.radred.CheckedChanged += new System.EventHandler(this.radred_CheckedChanged);
            // 
            // radgreen
            // 
            this.radgreen.AutoSize = true;
            this.radgreen.ForeColor = System.Drawing.Color.Green;
            this.radgreen.Location = new System.Drawing.Point(19, 59);
            this.radgreen.Name = "radgreen";
            this.radgreen.Size = new System.Drawing.Size(81, 28);
            this.radgreen.TabIndex = 3;
            this.radgreen.TabStop = true;
            this.radgreen.Text = "Green";
            this.radgreen.UseVisualStyleBackColor = true;
            this.radgreen.CheckedChanged += new System.EventHandler(this.radgreen_CheckedChanged);
            // 
            // radblack
            // 
            this.radblack.AutoSize = true;
            this.radblack.Location = new System.Drawing.Point(19, 113);
            this.radblack.Name = "radblack";
            this.radblack.Size = new System.Drawing.Size(73, 28);
            this.radblack.TabIndex = 3;
            this.radblack.TabStop = true;
            this.radblack.Text = "Black";
            this.radblack.UseVisualStyleBackColor = true;
            this.radblack.CheckedChanged += new System.EventHandler(this.radblack_CheckedChanged);
            // 
            // radblue
            // 
            this.radblue.AutoSize = true;
            this.radblue.ForeColor = System.Drawing.Color.Blue;
            this.radblue.Location = new System.Drawing.Point(19, 86);
            this.radblue.Name = "radblue";
            this.radblue.Size = new System.Drawing.Size(65, 28);
            this.radblue.TabIndex = 3;
            this.radblue.TabStop = true;
            this.radblue.Text = "blue";
            this.radblue.UseVisualStyleBackColor = true;
            this.radblue.CheckedChanged += new System.EventHandler(this.radblue_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.radblue);
            this.groupBox1.Controls.Add(this.radblack);
            this.groupBox1.Controls.Add(this.radgreen);
            this.groupBox1.Controls.Add(this.radred);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // txtnhapten
            // 
            this.txtnhapten.Location = new System.Drawing.Point(104, 69);
            this.txtnhapten.Name = "txtnhapten";
            this.txtnhapten.Size = new System.Drawing.Size(155, 20);
            this.txtnhapten.TabIndex = 1;
            this.txtnhapten.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(422, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Định_dang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtlaptrinh);
            this.Controls.Add(this.txtnhapten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Định_dang";
            this.Text = "Lập trình bởi";
            this.Load += new System.EventHandler(this.Định_dang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtlaptrinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkBlod;
        private System.Windows.Forms.CheckBox chkchan;
        private System.Windows.Forms.CheckBox chkitalic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radred;
        private System.Windows.Forms.RadioButton radgreen;
        private System.Windows.Forms.RadioButton radblack;
        private System.Windows.Forms.RadioButton radblue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnhapten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}