using System.Collections.Generic;
using YSKProje.Entities.Interfaces;

namespace YSKProje.Entities.Concrete
{
    public class Category : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CategoryBlog> categoryBlogs { get; set; }
    }
}
