using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OAuthTokenWebAPI.Controllers
{
    [RoutePrefix("api/Employee")]
    public class EmployeeController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(Employee.CreateOrders());
        }
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public bool IsFullTime { get; set; }

        public static List<Employee> CreateOrders()
        {
            List<Employee> empList = new List<Employee>
            {
                new Employee {EmployeeID = 10248, EmployeeName = "Taiseer Joudeh",  IsFullTime = true },
                new Employee {EmployeeID = 10249, EmployeeName = "Ahmad Hasan", IsFullTime = false},
                new Employee {EmployeeID = 10250,EmployeeName = "Tamer Yaser",  IsFullTime = false },
                new Employee {EmployeeID = 10251,EmployeeName = "Lina Majed",  IsFullTime = false},
                new Employee {EmployeeID = 10252,EmployeeName = "Yasmeen Rami", IsFullTime = true}
            };

            return empList;
        }
    }
}
