using ShopItlaApp.Data.Entities;

namespace ShopItlaApp.Data.Models.CategoriesModifiers
{
    public class CategoriesUpdateModel : Categories
    {
        public DateTime? ModifyDate { get; set; }
        public int? ModifyUser { get; set; }
        public object?[]? CategoriesID { get; internal set; }
    }
}
