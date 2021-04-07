using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Components
{
    public class BrandsViewComponent : ViewComponent
    {
        private readonly IProductData ProductData;

        public BrandsViewComponent(IProductData productData)
        {
            ProductData = productData;
        }

        public IViewComponentResult Invoke() => View(GetBrands());

        private IEnumerable<BrandViewModel> GetBrands() =>
            ProductData.GetBrands()
               .OrderBy(b => b.Order)
               .Select(b => new BrandViewModel
               {
                   id = b.id,
                   Name = b.Name
               });
    }
}
