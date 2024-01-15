using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        public string status { get; set; }

    }
}
