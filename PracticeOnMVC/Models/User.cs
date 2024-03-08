using System.ComponentModel.DataAnnotations;

namespace PracticeOnMVC.Models
{
    public class User
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Passwaord { get; set; }
        [Required]
        public string? Email {  get; set; }
    }
}
