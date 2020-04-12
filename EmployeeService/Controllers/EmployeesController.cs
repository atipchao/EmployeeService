using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
    public class EmployeesController : ApiController
    {
        [Authorize]
        public IEnumerable<Employee> Get()
        {
            EmployeeServiceEntities _db = new EmployeeServiceEntities();
            IEnumerable<Employee> empList;
            try
            {
                empList = _db.Employees.ToList();
                
            }
            catch(Exception e)
            {
                empList = null;
            }
            finally
            {
                
            }
            return empList;
            
        }
    }
}
