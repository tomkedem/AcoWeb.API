using AcoWeb.API.DTOs;
using AcoWeb.API.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AcoWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeesRepository _employeesrepository;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeesRepository employeesRepository, IMapper mapper)
        {
            _employeesrepository = employeesRepository;
            _mapper = mapper;
        }

        [HttpGet("{officeId}")]
        public IActionResult GetEmployees(Guid officeId)
        {
            var employees = _employeesrepository.GetEmployees(officeId);
            return Ok(employees);
        }
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employeeList = _employeesrepository.GetEmployees();

            var employeesDtoList = _mapper.Map<List<GetEmployeesDto>>(employeeList);

            return Ok(employeesDtoList.ToList());
        }

    }
}
