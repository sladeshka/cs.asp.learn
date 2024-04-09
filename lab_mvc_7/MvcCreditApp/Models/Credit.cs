using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCreditApp.Models
{
    public class Credit
    {
        public virtual int CreditId { get; set; }
        [DisplayName("Loan name")]
        [Required]
        public virtual string Head { get; set; }
        [DisplayName("Loan name")]
        [Required]
        public virtual int Period { get; set; }
        [DisplayName("Loan name")]
        [Required]
        public virtual int Sum { get; set; }
        [DisplayName("Loan name")]
        [Required]
        public virtual int Procent { get; set; }
    }
}
