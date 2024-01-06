// Derived class for animals inheriting from LivingOrganisms
public class Animals : LivingOrganisms
{
    // Protected method for adaptation specific to animals
    protected void Adaptation()
    {
        Console.WriteLine("Animals can adapt.");
    }

    // Subclass for reptiles inheriting from Animals
    public class Reptiles : Animals
    {
        // Constructor for Reptiles class
        public Reptiles()
        {
            base.Adaptation(); // Accessing a method from the base class using 'base'
            base.Nutrition(); // Animals class inherits methods from LivingOrganisms
            base.Excretion();
            base.Respiration();
        }

        // Specific method for reptiles
        public void MoveByCrawling()
        {
            Console.WriteLine("Reptiles move by crawling.");
        }
    }
 // Another subclass for birds inheriting from Animals
    public class Birds : Animals
    {
        // Constructor for Birds class
        public Birds()
        {
            base.Adaptation();
            base.Nutrition();
            base.Excretion();
            base.Respiration();
        }

        // Specific method for birds
        public void Fly()
        {
            Console.WriteLine("Birds can fly.");
        }
    }
}
