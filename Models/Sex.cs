using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class Sex
    {
        [Key]
        public int Id { get; set; }
        public string sex { get; set; }
    }
}
