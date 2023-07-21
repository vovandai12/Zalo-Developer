namespace Zalo_Tool_V1
{
    partial class FormDemo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnDemo = new Button();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button5 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BtnDemo
            // 
            BtnDemo.Location = new Point(12, 12);
            BtnDemo.Name = "BtnDemo";
            BtnDemo.Size = new Size(108, 37);
            BtnDemo.TabIndex = 3;
            BtnDemo.Text = "Mở trình duyệt";
            BtnDemo.UseVisualStyleBackColor = true;
            BtnDemo.Click += BtnDemo_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 70);
            button1.Name = "button1";
            button1.Size = new Size(108, 37);
            button1.TabIndex = 4;
            button1.Text = "Đóng trình duyệt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 123);
            button2.Name = "button2";
            button2.Size = new Size(108, 37);
            button2.TabIndex = 5;
            button2.Text = "Mở Zalo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1277, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 187);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(12, 176);
            button3.Name = "button3";
            button3.Size = new Size(122, 37);
            button3.TabIndex = 7;
            button3.Text = "Lấy QR đăng nhập";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(760, 4);
            button4.Name = "button4";
            button4.Size = new Size(162, 37);
            button4.TabIndex = 8;
            button4.Text = "Đăng nhập bằng cookie";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(937, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 23);
            textBox1.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(1087, 209);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(387, 469);
            listBox1.TabIndex = 10;
            // 
            // button5
            // 
            button5.Location = new Point(12, 234);
            button5.Name = "button5";
            button5.Size = new Size(122, 37);
            button5.TabIndex = 11;
            button5.Text = "Lấy dữ liệu cá nhân";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(1109, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(153, 156);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // FormDemo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 690);
            Controls.Add(pictureBox2);
            Controls.Add(button5);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BtnDemo);
            Name = "FormDemo";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtToken;
        private Label label1;
        private ListBox lbJson;
        private Button BtnDemo;
        private Label label2;
        private TextBox txtSecretKey;
        private Button btngetAccessToken;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button5;
        private PictureBox pictureBox2;
    }
}