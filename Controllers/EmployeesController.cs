using Microsoft.AspNetCore.Mvc;
using ServerMySQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMySQL.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            EmployeeContext context = HttpContext.RequestServices.GetService(typeof(ServerMySQL.Models.EmployeeContext)) as EmployeeContext;

            return View(context.GetAllEmployees());
        }
    }
}
