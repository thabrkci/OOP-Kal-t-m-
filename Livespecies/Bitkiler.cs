// Derived class for plants inheriting from LivingOrganisms
public class Plants : LivingOrganisms
{
    // Protected method for photosynthesis specific to plants
    protected void PerformPhotosynthesis()
    {
        Console.WriteLine("Plants perform photosynthesis.");
    }

    // Subclass for Seed Plants inheriting from Plants
    public class SeedPlants : Plants
    {
        // Constructor for SeedPlants class
        public SeedPlants()
        {
            base.PerformPhotosynthesis();
        }

        // Specific method for seed plants
        public void ReproduceBySeeds()
        {
            Console.WriteLine("Seed plants reproduce by seeds.");
        }
    }
     // Another subclass for Seedless Plants inheriting from Plants
    public class SeedlessPlants : Plants
    {
        // Constructor for SeedlessPlants class
        public SeedlessPlants()
        {
            base.PerformPhotosynthesis();
        }

        // Specific method for seedless plants
        public void ReproduceBySpores()
        {
            Console.WriteLine("Seedless plants reproduce by spores.");
        }
    }
}
