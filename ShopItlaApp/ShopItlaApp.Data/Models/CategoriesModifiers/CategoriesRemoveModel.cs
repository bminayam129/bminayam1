using ShopItlaApp.Data.Entities;


namespace ShopItlaApp.Data.Models.CategoriesModifiers
{
    public class CategoriesRemoveModel : Categories
    {
        internal int CategoriesID;

        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool Deleted { get; set; }

    }
}
