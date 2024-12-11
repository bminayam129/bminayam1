

namespace ShopItlaApp.Data.Models.CategoriesModifiers
{
    public class GetCategoriesModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public object DateTime { get; internal set; }
        public int CreationUser { get; internal set; }
    }
}
