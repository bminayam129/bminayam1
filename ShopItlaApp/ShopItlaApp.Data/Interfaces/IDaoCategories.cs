

using ShopItlaApp.Data.Models.CategoriesModifiers;

namespace ShopItlaApp.Data.Interfaces
{
    public interface IDaoCategories
    {
        void CreateCategories(CategoriesCreateModel CategoriesCreateModel);
        void UpdateCategories(CategoriesUpdateModel categoriesUpdateModel);
        void RemoveCategories (CategoriesRemoveModel categoriesRemoveModel);

        GetCategoriesModel GetCategoriesById(int id);

        List<GetCategoriesModel> GetCategories();

    }
}
