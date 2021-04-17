using System.Collections.Generic;
using WebStore.Domain;
using WebStore.Domain.Entities.Base;

namespace WebStore.Infrastructure.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Brand> GetBrands();

        IEnumerable<Section> GetSections();

        IEnumerable<Product> GetProducts(ProductFilter productFilter = null);
    }
}
