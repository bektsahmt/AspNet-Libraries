using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.SRP.BadCoded
{
	public class Product
	{
		public int Id { get; set; }
        public string Name { get; set; }

        private static List<Product> ProductsList = new List<Product>();
        public Product()
        {
            ProductsList = new()
            {
                new() { Id = 1, Name="Kalem 1"},
                new() { Id = 2, Name="Kalem 2"},
                new() { Id = 3, Name="Kalem 3"},
                new() { Id = 4, Name="Kalem 4"},
                new() { Id = 5, Name="Kalem 5"}
            };
        }

        public void SaveOrUpdate(Product product)
        {
            var hasProduct = ProductsList.Any(p => p.Id == product.Id);

            if(!hasProduct)
            {
                ProductsList.Add(product);
            }
            else
            {
                var index = ProductsList.FindIndex(x => x.Id == product.Id);

                ProductsList[index] = product;
            }
        }

        public void Delete(int id)
        {
            var hasProduct = ProductsList.Find(x => x.Id == id);

            if(hasProduct == null)
            {
                throw new Exception("Ürün Bulunamadı");
            }
            ProductsList.Remove(hasProduct);
         
        }

        public void WriteToConsole()
        {
            ProductsList.ForEach(x =>
            {
                Console.WriteLine($"{x.Id}- {x.Name}");
            });
        }

    }
}
