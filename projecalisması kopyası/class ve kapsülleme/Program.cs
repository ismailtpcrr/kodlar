
class Program
{

    static void Main()
    {

        Product p1 = new Product();
        p1.UrunAdi = "Elma";
        p1.Fiyati = 15;
        p1.Aciklama = "amasya elması";

        Product p2 = new Product();
        p2.UrunAdi = "karpuz";
        p2.Fiyati = 80;
        p2.Aciklama = "diyarbakır karpuzu";
        p2.StokAdeti = 30;


        Product[] urunler = new Product[]{p1,p2};

        // tip güvenli -type safe
        foreach (Product urun in urunler)
        {
            Console.WriteLine(urun.Fiyati); 
            
        }

        SepetManager SM = new SepetManager();
        
        SM.Ekle(p1);
        SM.Ekle(p2);
        
        SM.ekle2(p2);


    }
}

