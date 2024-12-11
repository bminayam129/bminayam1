using ShopItlaApp.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace ShopItlaApp.Data.Entities
{
    public class Products : AuditEntity
    {
        [Key] // Indica que es la clave primaria 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Esepcifica que es auto incremental 
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }

        //Validar que UnitPrice sea mayor a 0

        [Range(0.01, double.MaxValue, ErrorMessage = "UnitPrie debe ser mayor que 0.")]
        public decimal UnitPrice { get; set; }
        public bool Discontinued { get; set; }

        public void ValidarProductId()
        {
            if (ProductId <= 0)
            {
                throw new InvalidOperationException("El ProductId no es válido.");
            }

            // Consulta para verificar en la base de datos si el ID existe.
            bool productExists = false;
            if (productExists)
            {
                throw new InvalidOperationException("El ProductId ya existe.");
            }

            Console.WriteLine("El ProductId es válido.");


        }
        //Validar que el campo ProductName no este nulo o vacio y validar limite de caracteres
        public void ValidarProductName()
        {
            if (string.IsNullOrWhiteSpace(ProductName))
            {
                throw new ArgumentNullException("EL campo ProductName no puede estar vacio o nulo.");
            }
            else if (ProductName.Length > 40)
            {
                Console.WriteLine("Error: ProductName no puede tener mas de 40 Caracteres");
            }
            else
            {
                Console.WriteLine("Validacion Exitosa para ProductName.");
            }

        }
        public void ValidarSupplierId()
        {
            if (SupplierId <= 0)
            {
                throw new InvalidOperationException("El SupplierId no es válido.");
            }

            // Consulta para verificar en la base de datos si el ID existe.
            bool supplierExists = false;
            if (supplierExists)
            {
                throw new InvalidOperationException("El SupplierId ya existe.");
            }

            Console.WriteLine("El SupplierId es válido.");


        }
        public void ValidarCategoryId()
        {
            if (CategoryId <= 0)
            {
                throw new InvalidOperationException("El CategoryId no es válido.");
            }


            // Consulta para verificar en la base de datos si el ID existe.
            bool categoryExists = false;
            if (categoryExists)
            {
                throw new InvalidOperationException("El CategoryId ya existe.");
            }

            Console.WriteLine("El CategoryId es válido.");

        }
    }

}



