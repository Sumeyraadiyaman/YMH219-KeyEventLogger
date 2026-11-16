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
            lblStatsTitle = new Label();
            lblStats = new Label();
            SuspendLayout();
            // 
            // lstLog
            // 
            lstLog.BackColor = Color.FromArgb(252, 228, 236);
            lstLog.ForeColor = Color.FromArgb(136, 14, 79);
            lstLog.BorderStyle = BorderStyle.FixedSingle;
            lstLog.Font = new Font("Consolas", 10F);
            lstLog.FormattingEnabled = true;
            lstLog.Location = new Point(12, 12);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(440, 334);
            lstLog.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(76, 175, 80);
            btnStart.ForeColor = Color.White;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStart.Cursor = Cursors.Hand;
            btnStart.Location = new Point(470, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(150, 40);
            btnStart.TabIndex = 1;
            btnStart.Text = "▶ Başlat";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(229, 57, 53);
            btnStop.ForeColor = Color.White;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStop.Cursor = Cursors.Hand;
            btnStop.Location = new Point(470, 60);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(150, 40);
            btnStop.TabIndex = 2;
            btnStop.Text = "■ Durdur";
            btnStop.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(158, 158, 158);
            btnClear.ForeColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.Cursor = Cursors.Hand;
            btnClear.Location = new Point(470, 108);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 40);
            btnClear.TabIndex = 3;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(30, 136, 229);
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(470, 156);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Kaydet (.txt)";
            btnSave.UseVisualStyleBackColor = false;
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
            // lblStatsTitle
            // 
            lblStatsTitle.AutoSize = true;
            lblStatsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatsTitle.Location = new Point(470, 212);
            lblStatsTitle.Name = "lblStatsTitle";
            lblStatsTitle.TabIndex = 6;
            lblStatsTitle.Text = "İstatistik";
            // 
            // lblStats
            // 
            lblStats.BackColor = Color.White;
            lblStats.BorderStyle = BorderStyle.FixedSingle;
            lblStats.Font = new Font("Segoe UI", 9F);
            lblStats.Location = new Point(470, 236);
            lblStats.Name = "lblStats";
            lblStats.Padding = new Padding(4);
            lblStats.Size = new Size(150, 110);
            lblStats.TabIndex = 7;
            lblStats.Text = "Henüz kayıt yok.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(634, 401);
            Controls.Add(lstLog);
            Controls.Add(btnStart);
            Controls.Add(btnStop);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(lblStatus);
            Controls.Add(lblStatsTitle);
            Controls.Add(lblStats);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label lblStatsTitle;
        private Label lblStats;
    }
}