using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Components
{
    public class SectionsViewComponent : ViewComponent
    {
        private readonly IProductData ProductData;

        public SectionsViewComponent(IProductData productData) => ProductData = productData;


        public IViewComponentResult Invoke()
        {
            var sections = ProductData.GetSections();

            var parent_sections = sections.Where(s => s.ParentId is null);

            var parent_sections_views = parent_sections
               .Select(s => new SectionViewModel
               {
                   id = s.id,
                   Name = s.Name,
                   Order = s.Order
               })
               .ToList();

            foreach (var parent_section in parent_sections_views)
            {
                var child = sections.Where(s => s.ParentId == parent_section.id);

                foreach (var child_section in child)
                    parent_section.ChildSections.Add(new SectionViewModel
                    {
                        id = child_section.id,
                        Name = child_section.Name,
                        Order = child_section.Order,
                        Parent = parent_section
                    });

                parent_section.ChildSections.Sort((a, b) => Comparer<int>.Default.Compare(a.Order, b.Order));
            }

            parent_sections_views.Sort((a, b) => Comparer<int>.Default.Compare(a.Order, b.Order));

            return View(parent_sections_views);
        }
    }
}
