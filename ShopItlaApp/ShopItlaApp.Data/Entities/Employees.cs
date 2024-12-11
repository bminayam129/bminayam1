

using Microsoft.VisualBasic;
using ShopItlaApp.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopItlaApp.Data.Entities
{
    public class Employees : Person
    {
        [Key]// Indica que es la clave primaria 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// Esepcifica que es auto incremental 
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime HireDate { get; set; }
        public int? Mgrid { get; set; }

        //Validar que el campo LastName no este nulo o vacio y validar limite de caracteres 
        public void ValidarLastName()
        {
            if (string.IsNullOrWhiteSpace(LastName))
            {
                throw new ArgumentNullException("EL campo lastname no puede estar vacio o nulo.");
            }

            else if (LastName.Length > 20)
            {
                Console.WriteLine("Error: Primer Apellido no puede tener mas de 20 Caracteres");
            }
            else 
            {
                Console.WriteLine("Validacion Exitosa para LastName.");
            }

        }
        //Validar que el campo FirstName no este nulo o vacio y validar limite de caracteres 
        public void ValidarFirstName()
        {
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                throw new ArgumentNullException("EL campo FirstName no puede estar vacio o nulo.");
            }

            else if (FirstName.Length > 10)
            {
                Console.WriteLine("Error: Primer Nombre no puede tener mas de 10 Caracteres");
            }
            else
            {
                Console.WriteLine("Validacion Exitosa para LastName.");
            }
        }
        //Validar que el campo Title no este nulo o vacio y validar limite de caracteres 
        public void ValidarTitle()
        {
            if (string.IsNullOrWhiteSpace(Title))
            {
                throw new ArgumentNullException("EL campo Title no puede estar vacio o nulo.");
            }

            else if (Title.Length > 30)
            {
                Console.WriteLine("Error: Title no puede tener mas de 30 Caracteres");
            }
            else
            {
                Console.WriteLine("Validacion Exitosa para LastName.");
            }
        }
        //Validar que el campo TitleOfCourtesy no este nulo o vacio y validar limite de caracteres 
        public void ValidarTitleOfCourtesy()
        {
            if (string.IsNullOrWhiteSpace(TitleOfCourtesy))
            {
                throw new ArgumentNullException("EL campo TitleOfCourtesy no puede estar vacio o nulo.");
            }

            else if (TitleOfCourtesy.Length > 25)
            {
                Console.WriteLine("Error: Title no puede tener mas de 25 Caracteres");
            }
            else
            {
                Console.WriteLine("Validacion Exitosa para LastName.");
            }
        }
        //Validar que el campo Birthday no este nulo o vacio
        public void ValidarBirthday()
        {
            if (Birthday == default(DateTime))
            {
                throw new ArgumentNullException("El campo Birthday no puede estar vacío o nulo.");
            }
            else
            {
                Console.WriteLine("Validación exitosa para Birthday.");
            }

        }
    }
}