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
            button2 = new Button();
            button1 = new Button();
            BtnAddAccount = new Button();
            dataGridView1 = new DataGridView();
            clAccID = new DataGridViewTextBoxColumn();
            clAccFullName = new DataGridViewTextBoxColumn();
            clAccPhone = new DataGridViewTextBoxColumn();
            clAccPass = new DataGridViewTextBoxColumn();
            clAccGender = new DataGridViewTextBoxColumn();
            clAccBirthday = new DataGridViewTextBoxColumn();
            clAccProxy = new DataGridViewTextBoxColumn();
            clAccStatus = new DataGridViewTextBoxColumn();
            clAccAction = new DataGridViewButtonColumn();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabPage1.Controls.Add(button2);
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
            // button2
            // 
            button2.Location = new Point(285, 9);
            button2.Name = "button2";
            button2.Size = new Size(124, 36);
            button2.TabIndex = 7;
            button2.Text = "Thiết lập trình duyệt";
            button2.UseVisualStyleBackColor = true;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clAccID, clAccFullName, clAccPhone, clAccPass, clAccGender, clAccBirthday, clAccProxy, clAccStatus, clAccAction });
            dataGridView1.Location = new Point(0, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1497, 618);
            dataGridView1.TabIndex = 5;
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
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1497, 669);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Nhắn tin";
            tabPage2.UseVisualStyleBackColor = true;
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
            // FMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1507, 722);
            Controls.Add(label3);
            Controls.Add(tabControl1);
            Name = "FMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zalo Tool";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn clAccID;
        private DataGridViewTextBoxColumn clAccFullName;
        private DataGridViewTextBoxColumn clAccPhone;
        private DataGridViewTextBoxColumn clAccPass;
        private DataGridViewTextBoxColumn clAccGender;
        private DataGridViewTextBoxColumn clAccBirthday;
        private DataGridViewTextBoxColumn clAccProxy;
        private DataGridViewTextBoxColumn clAccStatus;
        private DataGridViewButtonColumn clAccAction;
    }
}