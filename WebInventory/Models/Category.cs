using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebInventory.Models
{
    public class Category
    {
        [Key]
        public int Id_Category { get; set; }

        [Required(ErrorMessage = "La Descripcion es requerida")]
        [MaxLength(150, ErrorMessage = "El maximo de caracteres es 150")]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }
    }
}
