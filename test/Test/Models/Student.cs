using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Group { get; set; }

        [Required]
        public int Score { get; set; }
    }
}
