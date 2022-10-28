using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() {Name = "Playstation", Price = 500},
            new Product() {Name = "Drums", Price = 250},
            new Product() {Name = "Chair", Price = 325},
            new Product() {Name = "Sword", Price = 800}
        };
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from a List Database");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a List Database");
        }
    }
}
