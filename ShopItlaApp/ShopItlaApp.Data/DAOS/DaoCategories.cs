

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShopItlaApp.Data.Context;
using ShopItlaApp.Data.Exceptions;
using ShopItlaApp.Data.Interfaces;
using ShopItlaApp.Data.Models.CategoriesModifiers;

namespace ShopItlaApp.Data.DAOS
{
    public class DaoCategories : IDaoCategories
    {
        private readonly ShopContext _context;
        private readonly ILogger<DaoCategories> _logger;
        private object category;

        public object Categoriesupdate { get; private set; }

        public DaoCategories(ShopContext context, ILogger<DaoCategories> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void CreateCategories(CategoriesCreateModel categoriesCreate)
        {
            try
            {
                if (categoriesCreate is null)
                {
                    throw new CategoriesDaoExceptions("Debe suministrar el parámetro.");
                }

                // Validar campos obligatorios
                if (string.IsNullOrEmpty(categoriesCreate.CategoryName))
                {
                    throw new CategoriesDaoExceptions("El campo 'CategoryName' no puede estar vacío.");
                }

                if (string.IsNullOrEmpty(categoriesCreate.Description))
                {
                    throw new CategoriesDaoExceptions("El campo 'Description' no puede estar vacío.");
                }

                // Crear la instancia de la categoría
                var category = new ShopItlaApp.Data.Entities.Categories
                {
                    Id = categoriesCreate.Id,
                    CategoryName = categoriesCreate.CategoryName,
                    Description = categoriesCreate.Description,
                    CreationDate = DateTime.Now,
                    CreationUser = categoriesCreate.CreateCategoryId
                };


                // Agregar y guardar en la base de datos
                _context.Categories.Add(category);
                _context.SaveChanges();

                _logger.LogInformation("Categoría creada correctamente.");
            }
            catch (Exception ex)
            {
                _logger.LogError("Error al intentar crear la categoría.", ex.ToString());
            }
        }

        public ShopContext Get_context()
        {
            return _context;
        }

        public async Task<GetCategoriesModel> GetCategoriesById(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw new CategoriesDaoExceptions("Suministre un numero de ID correcto.");
                }

                // Buscar la categoría por ID en la base de datos
                var categories = await _context.Categories.FindAsync(id);

                if (category == null)
                {
                    _logger.LogWarning($"Categoría no encontrada para el ID: {id}");

                    return null;
                }

                // Mapear los datos a la clase GetCategoriesModel
                var categoryModel = new GetCategoriesModel
                {
                    Id = categories.Id,
                    CategoryName = categories.CategoryName,
                    Description = categories.Description,
                    CreationDate = categories.CreationDate,
                    CreationUser = categories.CreationUser
                };

                return categoryModel;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error al obtener la categoría por ID.", ex.ToString());
                return null;
            }
        }
        public List<GetCategoriesModel> GetCategories()
        {
            List<GetCategoriesModel> categoriesList = new List<GetCategoriesModel>();
            try
            {
              

                categoriesList = (from categories in _context.Categories
                                  where categories.Deleted == false
                                  select new GetCategoriesModel()
                                  {
                                      Id = categories.Id,
                                      CategoryName = categories.CategoryName,
                                      Description = categories.Description,
                                      CreationDate = categories.CreationDate,
                                      CreationUser = categories.CreationUser,

                                  }).ToList();
                     
            }
            catch (Exception ex)
            {
                _logger.LogError("Ocurrio un error obteniendo las Categorias.", ex.ToString());
            }
            return categoriesList;
        }

        public void RemoveCategories(CategoriesRemoveModel categoriesRemoveModel)
        {
            try
            {
                // Validación de datos de entrada
                if (categoriesRemoveModel is null || categoriesRemoveModel.CategoriesID <= 0)
                {
                    throw new CategoriesDaoExceptions("Error al eliminar parámetro. El ID de la categoría no es válido.");
                }

                // Buscar la categoría en la base de datos
                var categoryToRemove = _context.Categories.Find(categoriesRemoveModel.CategoriesID);

                // Validar si la categoría existe
                if (categoryToRemove == null)
                {
                    _logger.LogWarning($"Categoría con ID {categoriesRemoveModel.CategoriesID} no encontrada.");
                    return;
                }
                categoryToRemove.CategoryName = categoriesRemoveModel.CategoryName;
                categoryToRemove.Description = categoriesRemoveModel.Description;
                categoryToRemove.CreationDate = DateTime.Now; // O la fecha que consideres

                // Guardar los cambios en la base de datos
                _context.Categories.Update(categoryToRemove);
                _context.SaveChanges();

                _logger.LogInformation("Categoría actualizada correctamente.");
                // Eliminar la categoría de la base de datos
                _context.Categories.Remove(categoryToRemove);
                _context.SaveChanges();

                _logger.LogInformation("Categoría eliminada correctamente.");
            }
            catch (Exception ex)
            {
                _logger.LogError("Error al intentar eliminar la categoría.", ex.ToString());
            }
        }

        public void UpdateCategories(CategoriesUpdateModel categoriesUpdateModel)
        {
            try
            {

                if (Categoriesupdate is null)
                {
                    throw new CategoriesDaoExceptions("Debe suministrar el parámetro.");
                }

                // Buscar la categoría en la base de datos

                var categoryToUpdate = _context.Categories.Find(categoriesUpdateModel.CategoriesID);

                // Validar si la categoría existe

                if (categoryToUpdate == null)
                {
                    _logger.LogWarning($"Categoría con ID {categoriesUpdateModel.CategoriesID} no encontrada.");
                    return;
                }

                // Actualizar los campos relevantes con los datos del modelo

                categoryToUpdate.CategoryName = categoriesUpdateModel.CategoryName;
                categoryToUpdate.Description = categoriesUpdateModel.Description;
                categoryToUpdate.CreationDate = DateTime.Now; // O la fecha que consideres

                // Guardar los cambios en la base de datos
                _context.Categories.Update(categoryToUpdate);
                _context.SaveChanges();

                _logger.LogInformation("Categoría actualizada correctamente.");
            }
            catch (Exception ex)
            {
                _logger.LogError("Error al buscar ID.", ex.ToString());
            }
        }



        GetCategoriesModel IDaoCategories.GetCategoriesById(int id)
        {
            throw new NotImplementedException();
        }
    }

    internal class Categories
    {
        public string CategoryName { get; internal set; }
        public string Description { get; internal set; }
        public int Id { get; internal set; }
        public DateTime CreationDate { get; internal set; }
        public int CreationUser { get; internal set; }
    }
}
