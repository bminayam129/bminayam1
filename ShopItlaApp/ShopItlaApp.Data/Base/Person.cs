

using ShopItlaApp.Data.Base;

namespace ShopItlaApp.Data.Entities
{
    public class Person : AuditEntity
    {

        //Informacion de direccion y contacto 

        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        //Validar que el campo Address no este nulo o vacio y validar limite de caracteres 
        public void ValidarAddress()
        {
            if (string.IsNullOrWhiteSpace(Address))
            {
                throw new ArgumentNullException("EL campo Address no puede estar vacio o nulo.");
            }
            else if (Address.Length > 60)
            {
                Console.WriteLine("Error: Address no puede tener mas de 60 Caracteres");
            }
            else
            {
                Console.WriteLine("Validacion Exitosa para Address.");
            }

        }
        //Validar que el campo City no este nulo o vacio y validar limite de caracteres 
        public void ValidarCity()
        {
            if (string.IsNullOrWhiteSpace(City))
            {
                throw new ArgumentNullException("EL campo City no puede estar vacio o nulo.");
            }
            else if (City.Length > 15)
            {
                Console.WriteLine("Error: City no puede tener mas de 15 Caracteres");
            }
            else
            {
                Console.WriteLine("Validacion Exitosa para City.");
            }

        }
        //Validar que el campo Region no este nulo o vacio y validar limite de caracteres 
        public void ValidarRegion()
        {
            if (string.IsNullOrWhiteSpace(Region))
            {
                throw new ArgumentNullException("EL campo Region no puede estar vacio o nulo.");
            }
            else if (Region.Length > 15)
            {
                Console.WriteLine("Error: Region no puede tener mas de 15 Caracteres");
            }
            else
            {
                Console.WriteLine("Validacion Exitosa para Region.");
            }

        }
        //Validar que el campo PostalCode no este nulo o vacio y validar limite de caracteres 
        public void ValidarPostalCode()
        {
            if (string.IsNullOrWhiteSpace(PostalCode))
            {
                throw new ArgumentNullException("EL campo PostalCode no puede estar vacio o nulo.");
            }
            else if (PostalCode.Length > 10)
            {
                Console.WriteLine("Error: City no puede tener mas de 10 Caracteres");
            }
            else
            {
                Console.WriteLine("Validacion Exitosa para Postal Code.");
            }

        }
        //Validar que el campo Country no este nulo o vacio y validar limite de caracteres 
        public void ValidarCountry()
        {
            if (string.IsNullOrWhiteSpace(Country))
            {
                throw new ArgumentNullException("EL campo Country no puede estar vacio o nulo.");
            }
            else if (Country.Length > 15)
            {
                Console.WriteLine("Error: Country no puede tener mas de 15 Caracteres");
            }
            else
            {
                Console.WriteLine("Validacion Exitosa para Country.");
            }

        }
        //Validar que el campo Phone no este nulo o vacio y validar limite de caracteres 
        public void ValidarPhone()
        {
            if (string.IsNullOrWhiteSpace(Phone))
            {
                throw new ArgumentNullException("EL campo Country no puede estar vacio o nulo.");
            }
            else if (Country.Length > 24)
            {
                Console.WriteLine("Error: Phone no puede tener mas de 24 Caracteres");
            }
            else
            {
                Console.WriteLine("Validacion Exitosa para Phone.");
            }

        }

    }

}
