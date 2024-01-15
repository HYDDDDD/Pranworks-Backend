using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class GradeClass
    {
        [Key]
        public int Id { get; set; }
        public string gradeClass { get; set; }
    }
}
