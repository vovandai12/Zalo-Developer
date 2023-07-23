namespace Zalo_Tool_V1
{
    partial class FLogin
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
            pbQRCode = new PictureBox();
            BtnFLoginUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)pbQRCode).BeginInit();
            SuspendLayout();
            // 
            // pbQRCode
            // 
            pbQRCode.Location = new Point(12, 12);
            pbQRCode.Name = "pbQRCode";
            pbQRCode.Size = new Size(399, 399);
            pbQRCode.TabIndex = 0;
            pbQRCode.TabStop = false;
            // 
            // BtnFLoginUpdate
            // 
            BtnFLoginUpdate.Location = new Point(145, 417);
            BtnFLoginUpdate.Name = "BtnFLoginUpdate";
            BtnFLoginUpdate.Size = new Size(124, 36);
            BtnFLoginUpdate.TabIndex = 1;
            BtnFLoginUpdate.Text = "Cập nhật";
            BtnFLoginUpdate.UseVisualStyleBackColor = true;
            BtnFLoginUpdate.Click += BtnFLoginUpdate_Click;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 458);
            Controls.Add(BtnFLoginUpdate);
            Controls.Add(pbQRCode);
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zalo đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pbQRCode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbQRCode;
        private Button BtnFLoginUpdate;
    }
}