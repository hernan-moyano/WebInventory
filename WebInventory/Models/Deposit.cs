using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebInventory.Models
{
    public class Deposit
    {
        [Key]
        public int Id_Deposito { get; set; }

        [Required(ErrorMessage = "La Sucursal es requerida")]
        [MaxLength(150, ErrorMessage = "El maximo de caracteres es 150")]
        [Display(Name = "Sucursal")]
        public string Branch { get; set; }
        [Display(Name = "Capacidad ")]
        [Required(ErrorMessage = "Es necesario indicar la capacidad de almacenamiento")]
        public int Capacity { get; set; }
    }
}
