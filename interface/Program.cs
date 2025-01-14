


using System.Linq.Expressions;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManger = new KonutKrediManger();
IKrediManager esnafKrediManager = new EsnafKrediManager();

ILoggerService dataBaseLoggerService = new DateBaseLoggerService();
ILoggerService fileBaseLoggerService = new FileBaseLoggerService();
ILoggerService smsBaseLoggerService = new SmsLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(esnafKrediManager,new List<ILoggerService>{dataBaseLoggerService,fileBaseLoggerService,smsBaseLoggerService});

List<IKrediManager> krediler = new List<IKrediManager>{ihtiyacKrediManager,tasitKrediManager};

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);

