using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_mvc.Models;

namespace web_mvc.Controllers
{
    public class DepartmentController : Controller
    {

        public IActionResult Index() 
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Games"});
            list.Add(new Department { Id = 2, Name = "Games"});

            return View(list);
        }

    }
}