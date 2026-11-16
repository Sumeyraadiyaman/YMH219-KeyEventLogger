namespace YMH219_KeyEventLogger
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lstLog = new ListBox();
            btnStart = new Button();
            btnStop = new Button();
            btnClear = new Button();
            btnSave = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lstLog
            // 
            lstLog.FormattingEnabled = true;
            lstLog.ItemHeight = 15;
            lstLog.Location = new Point(12, 12);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(440, 334);
            lstLog.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(470, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(150, 40);
            btnStart.TabIndex = 1;
            btnStart.Text = "Başlat";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(470, 64);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(150, 40);
            btnStop.TabIndex = 2;
            btnStop.Text = "Durdur";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(470, 116);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 40);
            btnClear.TabIndex = 3;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(470, 168);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Kaydet (.txt)";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(12, 365);
            lblStatus.Name = "lblStatus";
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Durum: Durduruldu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 401);
            Controls.Add(lstLog);
            Controls.Add(btnStart);
            Controls.Add(btnStop);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(lblStatus);
            KeyPreview = true;
            Name = "Form1";
            Text = "Key Event Logger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLog;
        private Button btnStart;
        private Button btnStop;
        private Button btnClear;
        private Button btnSave;
        private Label lblStatus;
    }
}