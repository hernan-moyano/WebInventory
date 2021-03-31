using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebInventory.Data;

namespace WebInventory.Models
{
    public class Inventory
    {
        [Key]
        public int Id_Inventory { get; set; }
        [Display(Name = "Fecha")]
        [Required(ErrorMessage = " ")]
        public DateTime Date { get; set; }

        [Display(Name = "Depósito")]
        [Required(ErrorMessage = "Debe seleccionar una Depósito")]
        public int Id_Deposito { get; set; }

        [Display(Name = "Producto")]
        [Required(ErrorMessage = "Debe seleccionar una Producto")]
        public int Id_Product { get; set; }

        [Display(Name = "Unidades ")]
        [Required(ErrorMessage = "Es necesario cargar las unidades")]
        public int Units { get; set; }

        [Display(Name = "Costo Unitario")]
        [Required(ErrorMessage = "Es necesario cargar el costo unitario")]
        public decimal Unit_Cost { get; set; }

        [Display(Name = "Costo Total")]
        public decimal Total_Cost {
            get
            {
                return Units * Unit_Cost;
            }
                
            }
        
        public Product ProdNombre() {  
            var context = new ApplicationDbContext();
            var nombre = context.Product.Where(tp => tp.Id_Product == this.Id_Product).FirstOrDefault();
            return nombre;
             }

        public Deposit DepositNombre()
        {
            var context = new ApplicationDbContext();
            var nombre = context.Deposit.Where(td => td.Id_Deposito == this.Id_Deposito).FirstOrDefault();
            return nombre;
        }
    }
}
