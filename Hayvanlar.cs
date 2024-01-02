public class Hayvanlar:Canlilar
{
 protected void Adaptasyon()
 {

    Console.WriteLine("Hayvanlar adaptasyon kurabilir.");

 }

 public class Sürüngenler:Hayvanlar
 {


    public Sürüngenler()
    {
        base.Adaptasyon();//Base ile kalıtım aldığı sınıftan kullanılabilir yaptım.
        base.Beslenme();//Hayvanlar sınıfı canlılar sınıfından kalıtım almıştır.base ile kalıtım alan sınıfın kalıtım aldığı sınıfındaki nesneye erişebildim.
        base.Bosaltim();
        base.Solunum();
    }

    public void Surunerekhareketetme()
    {

        Console.WriteLine("Sürüngenler sürünerek hareket eder");

    }
    
 }
 public class birdü:Hayvanlar
    {


        public birdü()
    {
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
    }

    public void kuslarucar(){
        Console.WriteLine("Kuşlar uçar");
    }

    }


}