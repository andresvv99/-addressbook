

namespace MVC_address.Models
{
    using System.ComponentModel.DataAnnotations;

    public enum TypeContact
    {
        Correo,
        Telefono,
        Facebook
    }
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Tipo")]
        public TypeContact Type { get; set; }
        [Required]
        public string Contact { get; set; }
    
    
}
}