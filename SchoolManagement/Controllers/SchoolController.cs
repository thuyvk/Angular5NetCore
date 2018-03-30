using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Models;

namespace SchoolManagement.Controllers
{
    public class SchoolController : Controller
    {
        DataAccessLayer db = new DataAccessLayer();

        [HttpGet, Route("api/school/categories")]
        public IEnumerable<Categories> Index()
        {
            return db.GetCategories();
        }
    }
}