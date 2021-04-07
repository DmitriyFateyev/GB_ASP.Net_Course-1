using System.Collections.Generic;

namespace WebStore.ViewModels
{
    public class SectionViewModel
    {
        public int id { get; set; }

        public string Name { get; set; }

        public int Order{ get; set; }

        public SectionViewModel Parent { get; set; }

        public List<SectionViewModel> ChildSections { get; set; } = new();
    }
}
