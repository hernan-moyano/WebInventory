using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebInventory.Models
{
    public class Product
    {
        [Key]
        public int Id_Product { get; set; }

        [Display(Name = "Codigo del Producto")]
        [Required(ErrorMessage = "El codigo es requerido")]
        [MaxLength(20)]
        public string Alias { get; set; }

        [Required(ErrorMessage = "La Descripcion es requerida")]
        [MaxLength(150, ErrorMessage = "El maximo de caracteres es 150")]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Debe seleccionar una categoria")]
        public int Id_Category { get; set; }

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "Debe seleccionar un Tipo")]
        public int Id_Type { get; set; }

        [Display(Name = "Marca")]
        [Required(ErrorMessage = "Debe seleccionar una Marca")]
        public string Brand { get; set; }

        [Display(Name = "Imagen")]
        public string Image { get; set; }
    }
}
