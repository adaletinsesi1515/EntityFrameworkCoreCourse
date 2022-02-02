using System.Collections.Generic;

namespace UdemyEfCore.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductCategory> productCategories { get; set; }
    }
}
