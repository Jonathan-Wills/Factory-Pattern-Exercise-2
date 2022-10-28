namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Which database would you like to use?");
            Console.WriteLine($"Type sql");
            Console.WriteLine($"Type mongo");
            Console.WriteLine($"Type list");
            
            var userInput = Console.ReadLine();

#pragma warning disable CS8604 // Possible null reference argument.
            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);
#pragma warning restore CS8604 // Possible null reference argument.
            var products = db.LoadData();
            db.SaveData();

            foreach(var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }
        }
    }
}
