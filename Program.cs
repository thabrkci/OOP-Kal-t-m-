// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of SeedPlants class
        Plants.SeedPlants seedPlant = new Plants.SeedPlants();
        seedPlant.ReproduceBySeeds();

        // Creating an instance of Birds class
        Animals.Birds crow = new Animals.Birds();
        crow.Fly();
    }
}