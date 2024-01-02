namespace OOP_Kalıtım_;

/*                                               Canlılar
                                                     |
       (Hayvanlar ile aynı kalıtım) Bitkiler                  Hayvanlar(Canlılardan solunum boşaltım ve beslenme nesnesini almıştır kalıtım)
                     |                                                                                |
Tohumlu Bitkiler          Tohumsuz Bitkiler                     Sürüngenler                                           Kuşlar

*/class Program
{
    static void Main(string[] args)
    {
     
     Bitkiler.TohumluBitkiler tohumlubitki = new Bitkiler.TohumluBitkiler();
     /*tohumlubitki.Beslenme(); Tek Tek yazdırmak yerine protected ile korunan sınıflar ve içersindeki nesneleri
      base ile kullanmış(erişmiş) olduk direkt olarak canlılar sınıfına değil canlılar sınıfından kalıtım almış sınıflardan erişebiliriz.😊
     tohumlubitki.Solunum();  
     tohumlubitki.Bosaltim();
     tohumlubitki.Fotosentezyapmak();*/
     tohumlubitki.Tohumlacogalma();
      
     Hayvanlar.birdü karga = new Hayvanlar.birdü();
     /*karga.Solunum();
     karga.Beslenme();
     karga.Bosaltim();
     karga.Adaptasyon();*/
     karga.kuslarucar();

    

     
    




    }
}
