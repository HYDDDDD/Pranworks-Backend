using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        // auto-increment column
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string code { get; set; }

        [Required]
        [Column(TypeName = "varchar(1)")]
        public Sex sex { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string firstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string lastName { get; set; }

        [Required]
        [Column(TypeName = "varchar(1)")]
        public GradeClass gradeClass { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string tel { get; set; }

        [Required]
        [Column(TypeName = "varchar(12)")]
        public Status status { get; set; }
    }
}
