namespace IBASEmployeeService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using IBASEmployeeService.Models;
    
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }
        
        
        [HttpGet("GetEmployees")]
        public IEnumerable<Employee> Get()
        {
            var employees = new List<Employee>() {
            new Employee() {
                Id = "21",
                Name = "Mette Bangsbo",
                Email = "meba@ibas.dk",
                Department = new Department() {
                    Id = 1,
                    Name = "Salg"
                }
            },
            new Employee() {
                Id = "22",
                Name = "Hans Merkel",
                Email = "hame@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
                Id = "23",
                Name = "Karsten Mikkelsen",
                Email = "kami@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee()
            {
                Id = "24",
                Name = "Morten Sten",
                Email = "Morten@ibas.dk",
                Department = new Department() {
                    Id = 3,
                    Name = "Support"
            }
               },
            new Employee()
            {
                Id = "25",
                Name = "Bo Hansen",
                Email = "Bo@ibas.dk",
                Department = new Department()
                {
                    Id = 3,
                    Name = "Support"
                }
            }
        };
            return employees;
        }
        
        [HttpGet("GetAllEmployeesByDepartmentId/{departmentId}")]
        public IEnumerable<Employee> GetAllEmployeesByDepartment(int departmentId)
        {
            var FilteredEmployees = Get().Where(e => e.Department != null && e.Department.Id == departmentId);
            return FilteredEmployees;
        }
        
    }
}