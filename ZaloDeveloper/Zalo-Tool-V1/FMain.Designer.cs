namespace Zalo_Tool_V1
{
    partial class FMain
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button3 = new Button();
            BtnDevices = new Button();
            button1 = new Button();
            BtnAddAccount = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            button5 = new Button();
            richTextBox2 = new RichTextBox();
            label4 = new Label();
            button4 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            richTextBox1 = new RichTextBox();
            dataGridView2 = new DataGridView();
            clChatAccChoose = new DataGridViewCheckBoxColumn();
            clChatAccIndex = new DataGridViewTextBoxColumn();
            clChatAccFullName = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tabPage3 = new TabPage();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            clAccID = new DataGridViewTextBoxColumn();
            clAccFullName = new DataGridViewTextBoxColumn();
            clAccPhone = new DataGridViewTextBoxColumn();
            clAccPass = new DataGridViewTextBoxColumn();
            clAccGender = new DataGridViewTextBoxColumn();
            clAccBirthday = new DataGridViewTextBoxColumn();
            clAccProxy = new DataGridViewTextBoxColumn();
            clAccBrowser = new DataGridViewTextBoxColumn();
            clAccDevice = new DataGridViewTextBoxColumn();
            clAccStatus = new DataGridViewTextBoxColumn();
            clAccAction = new DataGridViewButtonColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1505, 697);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(BtnDevices);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(BtnAddAccount);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1497, 669);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Trang chủ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(425, 9);
            button3.Name = "button3";
            button3.Size = new Size(124, 36);
            button3.TabIndex = 8;
            button3.Text = "Cập nhật thông tin";
            button3.UseVisualStyleBackColor = true;
            // 
            // BtnDevices
            // 
            BtnDevices.Location = new Point(285, 9);
            BtnDevices.Name = "BtnDevices";
            BtnDevices.Size = new Size(124, 36);
            BtnDevices.TabIndex = 7;
            BtnDevices.Text = "Thiết lập máy ảo";
            BtnDevices.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(145, 9);
            button1.Name = "button1";
            button1.Size = new Size(124, 36);
            button1.TabIndex = 6;
            button1.Text = "Thiết lập Android";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtnAddAccount
            // 
            BtnAddAccount.Location = new Point(6, 9);
            BtnAddAccount.Name = "BtnAddAccount";
            BtnAddAccount.Size = new Size(124, 36);
            BtnAddAccount.TabIndex = 4;
            BtnAddAccount.Text = "Thêm tài khoản";
            BtnAddAccount.UseVisualStyleBackColor = true;
            BtnAddAccount.Click += BtnAddAccount_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clAccID, clAccFullName, clAccPhone, clAccPass, clAccGender, clAccBirthday, clAccProxy, clAccBrowser, clAccDevice, clAccStatus, clAccAction });
            dataGridView1.Location = new Point(0, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1491, 618);
            dataGridView1.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(richTextBox2);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1497, 669);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Nhắn tin";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(1364, 625);
            button5.Name = "button5";
            button5.Size = new Size(124, 36);
            button5.TabIndex = 9;
            button5.Text = "Gửi";
            button5.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(711, 62);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(777, 557);
            richTextBox2.TabIndex = 8;
            richTextBox2.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(711, 37);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 7;
            label4.Text = "Nội dung tin nhắn:";
            // 
            // button4
            // 
            button4.Location = new Point(316, 633);
            button4.Name = "button4";
            button4.Size = new Size(82, 28);
            button4.TabIndex = 6;
            button4.Text = "Xác nhận";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 640);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "Tìm kiếm:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 637);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 23);
            textBox1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(16, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 26);
            panel1.TabIndex = 3;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(143, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Số điện thoại";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(3, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(119, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Danh sách bạn bè";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(404, 62);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(301, 593);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { clChatAccChoose, clChatAccIndex, clChatAccFullName });
            dataGridView2.Location = new Point(16, 62);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(382, 565);
            dataGridView2.TabIndex = 1;
            // 
            // clChatAccChoose
            // 
            clChatAccChoose.FillWeight = 30F;
            clChatAccChoose.HeaderText = "";
            clChatAccChoose.Name = "clChatAccChoose";
            // 
            // clChatAccIndex
            // 
            clChatAccIndex.FillWeight = 30F;
            clChatAccIndex.HeaderText = "";
            clChatAccIndex.Name = "clChatAccIndex";
            // 
            // clChatAccFullName
            // 
            clChatAccFullName.HeaderText = "FullName";
            clChatAccFullName.Name = "clChatAccFullName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 0;
            label1.Text = "Bạn đang sử dụng tài khoản:";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1497, 669);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Nhóm";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Lime;
            label3.Location = new Point(7, 701);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 1;
            label3.Text = "Trạng thái: Đang chạy";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.FromArgb(0, 0, 192);
            progressBar1.ForeColor = Color.White;
            progressBar1.Location = new Point(1307, 700);
            progressBar1.Name = "progressBar1";
            progressBar1.RightToLeft = RightToLeft.No;
            progressBar1.Size = new Size(191, 16);
            progressBar1.TabIndex = 2;
            progressBar1.Tag = "";
            progressBar1.Value = 80;
            // 
            // clAccID
            // 
            clAccID.FillWeight = 62.0872459F;
            clAccID.HeaderText = "ID";
            clAccID.Name = "clAccID";
            clAccID.ReadOnly = true;
            // 
            // clAccFullName
            // 
            clAccFullName.FillWeight = 62.0872459F;
            clAccFullName.HeaderText = "Họ và tên";
            clAccFullName.Name = "clAccFullName";
            clAccFullName.ReadOnly = true;
            // 
            // clAccPhone
            // 
            clAccPhone.FillWeight = 62.0872459F;
            clAccPhone.HeaderText = "Số điện thoại";
            clAccPhone.Name = "clAccPhone";
            clAccPhone.ReadOnly = true;
            // 
            // clAccPass
            // 
            clAccPass.FillWeight = 62.0872459F;
            clAccPass.HeaderText = "Mật khẩu";
            clAccPass.Name = "clAccPass";
            clAccPass.ReadOnly = true;
            // 
            // clAccGender
            // 
            clAccGender.FillWeight = 62.0872459F;
            clAccGender.HeaderText = "Giới tính";
            clAccGender.Name = "clAccGender";
            clAccGender.ReadOnly = true;
            // 
            // clAccBirthday
            // 
            clAccBirthday.FillWeight = 62.0872459F;
            clAccBirthday.HeaderText = "Ngày sinh";
            clAccBirthday.Name = "clAccBirthday";
            clAccBirthday.ReadOnly = true;
            // 
            // clAccProxy
            // 
            clAccProxy.HeaderText = "Proxy";
            clAccProxy.Name = "clAccProxy";
            clAccProxy.ReadOnly = true;
            // 
            // clAccBrowser
            // 
            clAccBrowser.HeaderText = "Trình duyệt";
            clAccBrowser.Name = "clAccBrowser";
            clAccBrowser.ReadOnly = true;
            // 
            // clAccDevice
            // 
            clAccDevice.HeaderText = "Máy ảo";
            clAccDevice.Name = "clAccDevice";
            clAccDevice.ReadOnly = true;
            // 
            // clAccStatus
            // 
            clAccStatus.HeaderText = "Trạng thái";
            clAccStatus.Name = "clAccStatus";
            clAccStatus.ReadOnly = true;
            // 
            // clAccAction
            // 
            clAccAction.FillWeight = 30F;
            clAccAction.HeaderText = "";
            clAccAction.Name = "clAccAction";
            clAccAction.ReadOnly = true;
            clAccAction.Resizable = DataGridViewTriState.True;
            clAccAction.SortMode = DataGridViewColumnSortMode.Automatic;
            clAccAction.Text = "Sử dụng";
            clAccAction.UseColumnTextForButtonValue = true;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1507, 722);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(tabControl1);
            Name = "FMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zalo Tool";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button BtnAddAccount;
        private DataGridView dataGridView1;
        private Label label3;
        private Button BtnDevices;
        private Button button1;
        private Button button3;
        private DataGridView dataGridView2;
        private Label label1;
        private Panel panel1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RichTextBox richTextBox1;
        private Button button5;
        private RichTextBox richTextBox2;
        private Label label4;
        private Button button4;
        private Label label2;
        private TextBox textBox1;
        private DataGridViewCheckBoxColumn clChatAccChoose;
        private DataGridViewTextBoxColumn clChatAccIndex;
        private DataGridViewTextBoxColumn clChatAccFullName;
        private ProgressBar progressBar1;
        private DataGridViewTextBoxColumn clAccID;
        private DataGridViewTextBoxColumn clAccFullName;
        private DataGridViewTextBoxColumn clAccPhone;
        private DataGridViewTextBoxColumn clAccPass;
        private DataGridViewTextBoxColumn clAccGender;
        private DataGridViewTextBoxColumn clAccBirthday;
        private DataGridViewTextBoxColumn clAccProxy;
        private DataGridViewTextBoxColumn clAccBrowser;
        private DataGridViewTextBoxColumn clAccDevice;
        private DataGridViewTextBoxColumn clAccStatus;
        private DataGridViewButtonColumn clAccAction;
    }
}