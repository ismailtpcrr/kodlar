


using System.Linq.Expressions;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

IKrediManager tasitKrediManager = new TasitKrediManager();


IKrediManager konutKrediManger = new KonutKrediManger();


BasvuruManager basvuruManager = new BasvuruManager();
//basvuruManager.BasvuruYap(konutKrediManger);

List<IKrediManager> krediler = new List<IKrediManager>{ihtiyacKrediManager,tasitKrediManager};

basvuruManager.KrediOnBilgilendirmesiYap(krediler);

