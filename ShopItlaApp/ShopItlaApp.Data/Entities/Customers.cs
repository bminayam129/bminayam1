 

using ShopItlaApp.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace ShopItlaApp.Data.Entities
{
    public class Customers : Person
    {
        [Key] // Indica que es la clave primaria 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Esepcifica que es auto incremental 
        public int CustomerId { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Email { get; set; }
        public string? Fax { get; set; }

        //Validar que el campo Company no este nulo o vacio

        public void validateCompany()
        {
            if (string.IsNullOrEmpty(CompanyName))
            {
                Console.WriteLine("Error: El campo CompanyName no puede estar vacio o nulo.");
            }
            else
            {
                Console.WriteLine("Validacion exitosa");
            }

        }

        //Validar que el campo ContactName no este nulo o vacio

        public void validateContactName()
        {
            if (string.IsNullOrEmpty(ContactName))
            {
                Console.WriteLine("Error: El campo ContactName no puede estar vacio o nulo.");
            }
            else
            {
                Console.WriteLine("Validacion exitosa");
            }

        }

        //Validar que el campo Contact Title no este nulo o vacio

        public void validateContactTitle()
        {
            if (string.IsNullOrEmpty(ContactTitle))
            {
                Console.WriteLine("Error: El campo ContactTitle no puede estar vacio o nulo.");
            }
            else
            {
                Console.WriteLine("Validacion exitosa");
            }

        }
        //Validar que el campo Email no este nulo o vacio
        public void validateEmail()
        {
          
            if (string.IsNullOrEmpty(Email))
            {
                Console.WriteLine("Error: El campo Email no puede estar vacio o nulo.");
            }
            else
            {
                Console.WriteLine("Validacion exitosa");
            }
           

        }
    }
}
