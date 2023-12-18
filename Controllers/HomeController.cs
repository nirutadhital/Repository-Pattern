using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RepPatternDb.Models;
using RepPatternDb.Repository;

namespace RepPatternDb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IEmployee _employeeRepository;

    public HomeController(ILogger<HomeController> logger, IEmployee employeeRepository)
    {
        _logger = logger;
        _employeeRepository=  employeeRepository;
    }

    public List<Employee> getAllEmployee()
    {
        return _employeeRepository.getAllEmployee();
    }
    public Employee getEmployeeById(int id)
    {
        return _employeeRepository.getEmployeeById(id);
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
