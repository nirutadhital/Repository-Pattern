using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepPatternDb.Models;

namespace RepPatternDb.Repository
{
    public interface IEmployee
    {
        List<Employee> getAllEmployee();
        Employee getEmployeeById(int id);
    }
}