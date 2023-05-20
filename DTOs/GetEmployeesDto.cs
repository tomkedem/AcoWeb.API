using AcoWeb.API.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AcoWeb.API.DTOs
{
    public class GetEmployeesDto
    {       
        public Guid Id { get; set; }

      
        public string RoleInCompany { get; set; }
        public string FirstName { get; set; }       
        public string LastName { get; set; }       
        public DateTimeOffset HireDate { get; set; }



    }
}
