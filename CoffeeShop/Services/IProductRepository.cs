using CoffeeShop.Models;
using CoffeeShop.Models.Interfaces;

namespace CoffeeShop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
       
        private List<Product> ProductsList = new List<Product>
        {
            new Product { Id = 1, Name = "America", Price = 25, Detail = "Description...", ImageUrl = "https://link-anh.com", IsTrendingProduct = true },
            new Product { Id = 2, Name = "Vietnam", Price = 20, Detail = "Description...", ImageUrl = "https://link-anh.com", IsTrendingProduct = false },
            new Product { Id = 3, Name = "United Kingdom", Price = 15, Detail = "Description...", ImageUrl = "https://link-anh.com", IsTrendingProduct = true }
        };

        public IEnumerable<Product> GetAllProducts() => ProductsList;

        public Product GetProductDetail(int id) => ProductsList.FirstOrDefault(p => p.Id == id);

        public IEnumerable<Product> GetTrendingProducts() => ProductsList.Where(p => p.IsTrendingProduct);
    }
}