namespace RxMediaPharma.Entity.DTO
{
    public class ProductDetailDTO
    {
        public int Id { get; set; }
        public string IlacAdi { get; set; }
        public string Olcu { get; set; }
        public string Ambalaj { get; set; }
        public string Barkod { get; set; }
        public string Firma { get; set; }
        public decimal? Fiyat { get; set; }
        public string FiyatTarih { get; set; }
        public decimal? KamuFiyati { get; set; }
        public decimal? KamuOdenen { get; set; }
        public decimal? FiyatFark { get; set; }
        public decimal? DepocuFiyat { get; set; }
        public decimal? ImalatciFiyat { get; set; }
        public string JenerikOriginal { get; set; }
        public string SGKkodu { get; set; }
        public string ATCKodu { get; set; }
        public string Recete { get; set; }
        public bool Favori { get; set; }
        public byte[] Resim { get; set; }

    }
}
