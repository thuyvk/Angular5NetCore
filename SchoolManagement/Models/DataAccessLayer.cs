using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class DataAccessLayer
    {
        Ng5NetCoreContext context = new Ng5NetCoreContext();

        public List<Categories> GetCategories()
        {
            return context.Categories.ToList();
        }
    }
}
