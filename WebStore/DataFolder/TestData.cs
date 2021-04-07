using System.Collections.Generic;
using WebStore.Domain.Entities.Base;

namespace WebStore.Domain.TestData
{
    public class TestData
    {
        public static IEnumerable<Section> Sections { get; } = new[]
        {
              new Section { id = 1, Name = "Спорт", Order = 0 },
              new Section { id = 2, Name = "Nike", Order = 0, ParentId = 1 },
              new Section { id = 3, Name = "Under Armour", Order = 1, ParentId = 1 },
              new Section { id = 4, Name = "Adidas", Order = 2, ParentId = 1 },
              new Section { id = 5, Name = "Puma", Order = 3, ParentId = 1 },
              new Section { id = 6, Name = "ASICS", Order = 4, ParentId = 1 },
              new Section { id = 7, Name = "Для мужчин", Order = 1 },
              new Section { id = 8, Name = "Fendi", Order = 0, ParentId = 7 },
              new Section { id = 9, Name = "Guess", Order = 1, ParentId = 7 },
              new Section { id = 10, Name = "Valentino", Order = 2, ParentId = 7 },
              new Section { id = 11, Name = "Диор", Order = 3, ParentId = 7 },
              new Section { id = 12, Name = "Версачи", Order = 4, ParentId = 7 },
              new Section { id = 13, Name = "Армани", Order = 5, ParentId = 7 },
              new Section { id = 14, Name = "Prada", Order = 6, ParentId = 7 },
              new Section { id = 15, Name = "Дольче и Габбана", Order = 7, ParentId = 7 },
              new Section { id = 16, Name = "Шанель", Order = 8, ParentId = 7 },
              new Section { id = 17, Name = "Гуччи", Order = 9, ParentId = 7 },
              new Section { id = 18, Name = "Для женщин", Order = 2 },
              new Section { id = 19, Name = "Fendi", Order = 0, ParentId = 18 },
              new Section { id = 20, Name = "Guess", Order = 1, ParentId = 18 },
              new Section { id = 21, Name = "Valentino", Order = 2, ParentId = 18 },
              new Section { id = 22, Name = "Dior", Order = 3, ParentId = 18 },
              new Section { id = 23, Name = "Versace", Order = 4, ParentId = 18 },
              new Section { id = 24, Name = "Для детей", Order = 3 },
              new Section { id = 25, Name = "Мода", Order = 4 },
              new Section { id = 26, Name = "Для дома", Order = 5 },
              new Section { id = 27, Name = "Интерьер", Order = 6 },
              new Section { id = 28, Name = "Одежда", Order = 7 },
              new Section { id = 29, Name = "Сумки", Order = 8 },
              new Section { id = 30, Name = "Обувь", Order = 9 },
        };

        public static IEnumerable<Brand> Brands { get; } = new[]
        {
            new Brand { id = 1, Name = "Acne", Order = 0 },
            new Brand { id = 2, Name = "Grune Erde", Order = 1 },
            new Brand { id = 3, Name = "Albiro", Order = 2 },
            new Brand { id = 4, Name = "Ronhill", Order = 3 },
            new Brand { id = 5, Name = "Oddmolly", Order = 4 },
            new Brand { id = 6, Name = "Boudestijn", Order = 5 },
            new Brand { id = 7, Name = "Rosch creative culture", Order = 6 },
        };
    }
}
