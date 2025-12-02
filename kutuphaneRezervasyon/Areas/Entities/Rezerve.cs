using System;
using kutuphaneRezervasyon.Areas.Identity.Data;

namespace kutuphaneRezervasyon.Entities
{
    public class Rezerve
    {
        public int RezervasyonId { get; set; }
        public int KitapId { get; set; }
        public string KitapAdi { get; set; } = string.Empty;
        public string YazarAdi { get; set; } = string.Empty;
        public string Yayinevi { get; set; } = string.Empty;
        public int BasimYili { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now;
        public bool Durum { get; set; }

    }
}
