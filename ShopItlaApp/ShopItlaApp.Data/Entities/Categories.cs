

using ShopItlaApp.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopItlaApp.Data.Entities
{
    public  class Categories : AuditEntity
    {
        [Key] // Indica que es la clave primaria 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Esepcifica que es auto incremental 
      
        public int Id { get; set; }
       
        [Required(ErrorMessage = "El nombre de la categoria es obligatorio.")]
        [StringLength(15, ErrorMessage = "El nombre de la categoria no puede exceder los 15 caracteres.")]
        public string CategoryName { get; set; }
        
        [Required(ErrorMessage = "La descripcion es obligatoria.")]
        [StringLength(200, ErrorMessage = "El nombre de la categoria no puede exceder los 200 caracteres.")]
        public string Description { get; set; }

        public DateTime CreationDate { get; set; }
        public object DateTime { get; internal set; }
    }
}
