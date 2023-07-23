namespace Zalo_Tool_V1
{
    partial class FAccount
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
            richTextBox1 = new RichTextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            clFAccountCheck = new DataGridViewCheckBoxColumn();
            clFAccountPhone = new DataGridViewTextBoxColumn();
            clFAccountPass = new DataGridViewTextBoxColumn();
            clFAccountProxy = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 42);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(557, 213);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clFAccountCheck, clFAccountPhone, clFAccountPass, clFAccountProxy });
            dataGridView1.Location = new Point(12, 261);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(557, 376);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 15);
            label1.TabIndex = 2;
            label1.Text = "Định dạng: Số điện thoại|Mật khẩu|Proxy";
            // 
            // button1
            // 
            button1.Location = new Point(586, 42);
            button1.Name = "button1";
            button1.Size = new Size(124, 36);
            button1.TabIndex = 3;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(586, 90);
            button2.Name = "button2";
            button2.Size = new Size(124, 36);
            button2.TabIndex = 4;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(586, 144);
            button3.Name = "button3";
            button3.Size = new Size(124, 36);
            button3.TabIndex = 5;
            button3.Text = "Xoá";
            button3.UseVisualStyleBackColor = true;
            // 
            // clFAccountCheck
            // 
            clFAccountCheck.FillWeight = 50F;
            clFAccountCheck.HeaderText = "";
            clFAccountCheck.Name = "clFAccountCheck";
            // 
            // clFAccountPhone
            // 
            clFAccountPhone.HeaderText = "Số điện thoại";
            clFAccountPhone.Name = "clFAccountPhone";
            // 
            // clFAccountPass
            // 
            clFAccountPass.HeaderText = "Mật khẩu";
            clFAccountPass.Name = "clFAccountPass";
            // 
            // clFAccountProxy
            // 
            clFAccountProxy.HeaderText = "Proxy";
            clFAccountProxy.Name = "clFAccountProxy";
            // 
            // FAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 649);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(richTextBox1);
            Name = "FAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zalo thêm tài khoản";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewCheckBoxColumn clFAccountCheck;
        private DataGridViewTextBoxColumn clFAccountPhone;
        private DataGridViewTextBoxColumn clFAccountPass;
        private DataGridViewTextBoxColumn clFAccountProxy;
    }
}