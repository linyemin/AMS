using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AMS.Controllers
{
    public class CategoryController : Controller
    {
        // GET: /<controller>/
        [Route("/Category/{id:int}")]
        public IActionResult Index(int id)
        {
            return Content(id.ToString());
        }
    }
}
