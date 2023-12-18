using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepPatternDb.Data;
using RepPatternDb.Models;

namespace RepPatternDb.Repository
{
    public class EmployeeRepository : IEmployee
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Employee> getAllEmployee()
        {
            return _context.Employees.ToList();
        }

        public Employee getEmployeeById(int id)
        {
            return _context.Employees.Where(x=>x.Id==id).FirstOrDefault();
        }
    }
}