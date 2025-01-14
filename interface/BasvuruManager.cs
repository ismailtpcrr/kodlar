public class BasvuruManager
{
    //method injection
    public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> servisler)
    {   
        krediManager.Hesapla();
        foreach (ILoggerService service in servisler)
        {
            service.Log();
        }

    }    

    public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
    {
        foreach (IKrediManager kredi in krediler)
        {
            kredi.Hesapla();
        }
    }
}