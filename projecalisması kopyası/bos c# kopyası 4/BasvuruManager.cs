public class BasvuruManager
{
    public void BasvuruYap(IKrediManager krediManager)
    {   
        krediManager.Hesapla();
    }    

    public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
    {
        foreach (IKrediManager kredi in krediler)
        {
            kredi.Hesapla();
        }
    }
}