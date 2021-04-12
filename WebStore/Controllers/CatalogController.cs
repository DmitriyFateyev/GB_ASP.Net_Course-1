using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domain;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductData _ProductData;

        public CatalogController(IProductData ProductData) => _ProductData = ProductData;

        public IActionResult Index(int? brandId, int? sectionId)
        {
            var filter = new ProductFilter
            {
                BrandId = brandId,
                SectionId = sectionId,
            };

            var products = _ProductData.GetProducts(filter);

            var model = new CatalogViewModel()
            {
                BrandId = brandId,
                SectionId = sectionId,
                Products = products.Select(p => new ProductViewModel()
                {
                    id = p.id,
                    ImageUrl = p.ImageUrl,
                    Name = p.Name,
                    Order = p.Order,
                    Price = p.Price
                }).OrderBy(p => p.Order).ToList()
            };

            return View(model);
        }

        public IActionResult Shop(int? sectionId, int? brandId)
        {
            var products = _ProductData.GetProducts(new ProductFilter { BrandId = brandId, SectionId = sectionId });

            var model = new CatalogViewModel()
            {
                BrandId = brandId,
                SectionId = sectionId,
                Products = products.Select(p => new ProductViewModel()
                {
                    id = p.id,
                    ImageUrl = p.ImageUrl,
                    Name = p.Name,
                    Order = p.Order,
                    Price = p.Price
                }).OrderBy(p => p.Order).ToList()
            };

            return View(model);
        }

    }
}
