using System.ComponentModel.DataAnnotations;

namespace PricatMVC.Models
{
    public class Products
    {
        [Key]
        
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Imagen")]
        public String ImageName { get; set; }


        [Required]
        [Display(Name = "Nombre")]
        public String Name { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        [Display(Name = "Descripción")]
        public String Description { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        [Display(Name = "Precio")]
        public int Price { get; set; }
    }
}
