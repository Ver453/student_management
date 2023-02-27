
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Student_Management.Models
{
    public class FacultyModel
    {
        [Key]
        public int FacultyId { get; set; }
        [Required]
        [DisplayName("Faculty Name")]
        public string? Faculty_name { get; set; }
    }
}
