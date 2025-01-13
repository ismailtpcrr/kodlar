public class List<T>
{
    public T eklenenSayi { get; set; }

     public T[] dizi;

     public List()
     {
        dizi = new T[0];
     }

        public int count = 0;

    public void Add(T gelenDeger)
    {
        T[] tempArray = dizi;
        dizi = new T[dizi.Length+1];
        
        for(int i = 0; i<tempArray.Length; i++)
        {
            dizi[i] = tempArray[i];
        }
     
        dizi[dizi.Length-1] = gelenDeger;

        count++;
    }


}
