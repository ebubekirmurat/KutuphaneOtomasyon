namespace kutuphaneAPI.Class
{
    public class Kitap
    {
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string Yayinevi { get; set; }
        public int BasimYili { get; set; }
        public string Tarih { get; set; }
        public bool Durum { get; set; }
    }
}
