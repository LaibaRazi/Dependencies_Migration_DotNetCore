using System.ComponentModel.DataAnnotations;

namespace Dependencies.Models
{
    public class Emp
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
