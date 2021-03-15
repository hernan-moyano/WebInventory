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
    }
}
