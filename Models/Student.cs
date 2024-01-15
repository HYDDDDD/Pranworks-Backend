using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string code { get; set; }

        [Required]
        public string sex { get; set; }

        [Required]
        public string firstName { get; set; }

        [Required]
        public string lastName { get; set; }

        [Required]
        public string gradeClass { get; set; }

        public string tel { get; set; }

        [Required]
        public string status { get; set; }
    }
}
