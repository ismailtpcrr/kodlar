


GercekMusteri musteri1 = new GercekMusteri();
musteri1.MusteriNo = "123";
musteri1.Id = 1;


TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.MusteriNo = "124";
musteri2.Id = 2;
musteri2.SirketAdi = "isfurgames";
musteri2.VergiNo = "234";

// temel sınıf türetilmiş sınıfların referans değerlerini tutuyor
Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();

MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);