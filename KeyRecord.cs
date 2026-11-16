namespace YMH219_KeyEventLogger
{
    // Tek bir tuş basma olayını temsil eden sınıf
    public class KeyRecord
    {
        public Keys Key { get; }        // Basılan fiziksel tuş (A, Enter, Oem6...)
        public DateTime Time { get; }   // Basıldığı an

        // Tuştan çıkan gerçek karakter (ü, ş, ! ...). Sonradan gelir, o yüzden 'set' var.
        public char? Character { get; set; }

        public KeyRecord(Keys key, DateTime time)
        {
            Key = key;
            Time = time;
        }

        // Ekranda görünecek ad: karakter varsa onu, yoksa tuş adını kullan
        public string DisplayName
        {
            get
            {
                if (Character.HasValue)
                    return Character.Value.ToString().ToUpper();

                return Key.ToString();
            }
        }

        public override string ToString()
        {
            return $"[{Time:HH:mm:ss.fff}] {DisplayName}";
        }
    }
}