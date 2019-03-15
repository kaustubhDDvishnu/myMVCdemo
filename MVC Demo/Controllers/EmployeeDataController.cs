using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class EmployeeDataController : Controller
    {
        //https://www.c-sharpcorner.com/article/passing-data-from-controller-to-view-part-one/
        // GET: EmployeeData
        public ActionResult GetEmployeeData()
        {
            List<Employee> emp = new List<Employee>
            {
                new Employee
                {
                    EmployeeId = 1,
                    EmployeeName = "John",
                    Address = "Pune",
                    Phone = "2622838421"
                },
                new Employee
                {
                    EmployeeId = 2,
                    EmployeeName = "Smith",
                    Address = "Mumbai",
                    Phone = "2342244521"
                },
                new Employee
                {
                    EmployeeId = 3,
                    EmployeeName = "Marry",
                    Address = "Hyderabad",
                    Phone = "23446568421"
                }
            };

            return View(emp);
        }
    }
}