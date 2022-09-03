using System;
namespace telefonrehberi
{
    public class KisiBilgiKarti
    {
        string isim;

        public KisiBilgiKarti(string isim, string soyisim, string telefonNumarası)
        {
            Isim = isim;
            Soyisim = soyisim;
            TelefonNumarasi = telefonNumarası;
        }
        public KisiBilgiKarti()
        {

        }

        string soyisim;
        string telefonNumarası;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string TelefonNumarasi { get => telefonNumarası; set => telefonNumarası = value; }
    }
}