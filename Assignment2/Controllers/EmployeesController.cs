using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    public class EmployeesController : Controller
    {
       
        public IActionResult Index()
        {
            ViewBag.data = "Employee Data In  view Bag";
            ViewData["data"] = "Employee data in View Data";
            List<Employee> empobj = new List<Employee>()
        {
            new Employee(){Id=1,name="Biswajit",sal=45000},
            new Employee(){Id=2,name="Subrat",sal=50000},
            new Employee(){Id=3,name="Yesh",sal=4000},
            new Employee(){Id=4,name="Dev",sal=150000},
            new Employee(){Id=5,name="Devid",sal=54500},

        };
            ViewBag.data1 = empobj;
            return View(empobj);
        }
    }
}