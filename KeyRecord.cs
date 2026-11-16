namespace YMH219_KeyEventLogger
{
    // Tek bir tuş basma olayını temsil eden sınıf
    public class KeyRecord
    {
        public Keys Key { get; }        // Basılan tuş (A, Enter, Space...)
        public DateTime Time { get; }   // Basıldığı an

        public KeyRecord(Keys key, DateTime time)
        {
            Key = key;
            Time = time;
        }

        // Listede nasıl görüneceğini belirler: [17:35:12.481] A
        public override string ToString()
        {
            return $"[{Time:HH:mm:ss.fff}] {Key}";
        }
    }
}