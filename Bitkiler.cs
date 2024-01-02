public class Bitkiler : Canlilar
{

  protected void Fotosentezyapmak()
  {
    Console.WriteLine("Bitkiler fotosentez yapar.");
  }   
  


  public class TohumluBitkiler : Bitkiler
  {

    public TohumluBitkiler()
    {
        base .Fotosentezyapmak();
        
    }

    public void Tohumlacogalma(){
        Console.WriteLine("Tohumlu bitkiler tohumla çoğalır");
    }
  }


  public class TohumsuzBitkiler : Bitkiler
  {

     public TohumsuzBitkiler()
     {
        base.Fotosentezyapmak();
     }
    public void Sporlacogalma(){

        Console.WriteLine("Tohumsuz bitkiler sporla çoğalır");
    }
  }


}