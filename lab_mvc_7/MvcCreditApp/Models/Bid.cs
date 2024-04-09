using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCreditApp.Models
{
    public class Bid
    {
        public virtual int BidId { get; set; }
        [DisplayName("Applicant's name")]
        [Required]
        public virtual string Name { get; set; }
        [DisplayName("Loan name")]
        [Required]
        public virtual string CreditHead { get; set; }
        [DisplayName("Application date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public virtual DateTime bidDate { get; set; }
    }
}
