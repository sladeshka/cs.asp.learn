using System.ComponentModel;

namespace WebMVCR1.Models
{
    public class Person
    {
        [DisplayName("First name")]
        public string FirstName { get; set; }
        [DisplayName("Last name")]
        public string LastName { get; set; }
        public override string ToString() => FirstName + " " + LastName;
    }
}
