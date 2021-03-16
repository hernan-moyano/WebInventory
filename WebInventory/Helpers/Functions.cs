using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebInventory.Data;

namespace WebInventory.Helpers
{
    public class Functions
    {
        public static SelectList GetCategorys()
        {
            var dbContext = new ApplicationDbContext();
            var lstCategory = dbContext.Category.ToList();
            var SelectList = new SelectList(lstCategory, "Id_Category", "Description");
            return SelectList;
        }

        public static SelectList GetTipes()
        {
            var dbContext = new ApplicationDbContext();
            var lstType = dbContext.Type.ToList();
            var SelectList = new SelectList(lstType, "Id_Type", "Description");
            return SelectList;
        }
        public static SelectList GetDeposits()
        {
            var dbContext = new ApplicationDbContext();
            var lstDeposit = dbContext.Deposit.ToList();
            var SelectList = new SelectList(lstDeposit, "Id_Deposito", "Branch");
            return SelectList;
        }

        public static SelectList GetProducts()
        {
            var dbContext = new ApplicationDbContext();
            var lstProduct = dbContext.Product.ToList();
            var SelectList = new SelectList(lstProduct, "Id_Product", "Description");
            return SelectList;
        }
    }
}
