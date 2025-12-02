using System;

namespace kutuphaneRezervasyon.Models
{
    public class Kitap
    {
        public int KitapId { get; set; }
        public string KitapAdi { get; set; } = string.Empty;
        public string YazarAdi { get; set; } = string.Empty;
        public string Yayinevi { get; set; } = string.Empty;
        public int BasimYili { get; set; }
        public DateTime Tarih { get; set; }
        public bool Durum { get; set; }
    }
}
