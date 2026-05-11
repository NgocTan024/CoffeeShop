using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models.Interfaces;

namespace CoffeeShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        // Inject Interface vào thông qua Constructor
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Shop()
        {
            var products = _productRepository.GetAllProducts();
            return View(products); // Gửi danh sách sản phẩm sang View
        }
    }
}