using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebInventory.Models
{
    public class Type
    {
        [Key]
        public int Id_Type { get; set; }

        [Required(ErrorMessage = "La Descripcion es requerida")]
        [MaxLength(150, ErrorMessage = "El maximo de caracteres es 150")]
        [Display(Name = "Descripción")]
        public string Description { get; set; }
    }
}
