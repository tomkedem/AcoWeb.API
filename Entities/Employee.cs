
namespace AcoWeb.API.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Employee
{
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string RoleInCompany { get; set; }
    [Required]
    [MaxLength(35)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(35)]
    public string LastName { get; set; }

    [Required]
    public DateTimeOffset HireDate { get; set; }

    [Required]
    [MaxLength(35)]
    public decimal Salary { get; set; }

    [ForeignKey("OfficeId")]
    public Office Office { get; set; }

    public Guid OfficeId { get; set; }

    public virtual EmployeeAddress EmployeeAddress { get; set; }
}
