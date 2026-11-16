namespace YMH219_KeyEventLogger
{
    public partial class Form1 : Form
    {
        // Kayıt açık mı kapalı mı?
        private bool isRecording = false;

        // Yakalanan bütün tuş kayıtları
        private readonly List<KeyRecord> records = new List<KeyRecord>();

        public Form1()
        {
            InitializeComponent();

            // Olayları metotlara bağlıyoruz
            btnStart.Click += BtnStart_Click;
            btnClear.Click += BtnClear_Click;
            btnSave.Click += BtnSave_Click;
            KeyDown += Form1_KeyDown;

            UpdateStatus();
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            isRecording = true;
            UpdateStatus();
            lstLog.Focus(); // Odağı listeye ver ki Enter/Boşluk butona basmasın
        }

        private void BtnStop_Click(object? sender, EventArgs e)
        {
            isRecording = false;
            UpdateStatus();
        }

        // Pencere aktifken her tuşa basıldığında çalışır
        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (!isRecording)
                return; // Kayıt kapalıysa hiçbir şey yapma

            KeyRecord record = new KeyRecord(e.KeyCode, DateTime.Now);
            records.Add(record);
            lstLog.Items.Add(record.ToString());

            // Liste uzayınca otomatik olarak en alta kaydır
            lstLog.TopIndex = lstLog.Items.Count - 1;
        }

        // Ekrandaki ve hafızadaki kayıtları siler
        private void BtnClear_Click(object? sender, EventArgs e)
        {
            if (records.Count == 0)
                return; // Silinecek bir şey yoksa çık

            DialogResult answer = MessageBox.Show(
                "Tüm kayıtlar silinecek. Emin misiniz?",
                "Temizle",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                records.Clear();
                lstLog.Items.Clear();
            }
        }

        // Kayıtları kullanıcının seçtiği .txt dosyasına yazar
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (records.Count == 0)
            {
                MessageBox.Show("Kaydedilecek kayıt yok.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Metin dosyası (*.txt)|*.txt";
            dialog.FileName = $"keylog_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

            if (dialog.ShowDialog() != DialogResult.OK)
                return; // Kullanıcı vazgeçtiyse çık

            try
            {
                using StreamWriter writer = new StreamWriter(dialog.FileName);
                foreach (KeyRecord record in records)
                {
                    writer.WriteLine(record.ToString());
                }

                MessageBox.Show("Kayıtlar kaydedildi:\n" + dialog.FileName, "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya kaydedilemedi:\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Durum yazısını ve butonları güncel duruma göre ayarlar
        private void UpdateStatus()
        {
            if (isRecording)
            {
                lblStatus.Text = "Durum: Kayıt yapılıyor";
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                lblStatus.Text = "Durum: Durduruldu";
                lblStatus.ForeColor = Color.Red;
            }

            btnStart.Enabled = !isRecording; // Kayıt açıkken Başlat pasif
            btnStop.Enabled = isRecording;   // Kayıt kapalıyken Durdur pasif
        }
    }
}