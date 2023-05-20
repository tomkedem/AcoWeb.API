using System.ComponentModel.DataAnnotations;

namespace AcoWeb.API.Entities
{
    public class EmployeeAddress
    {
        [Key]
        public Guid Id { get; set; }
        public string HomeAddress { get; set; }
        public string City { get; set; }
        public Guid EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
