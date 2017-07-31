using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bank.Models
{
    public class CheckingAccount
    {

        public int id { get; set; }

        [Display(Name = "First Name")]
        public string fname { get; set; }

        [Display(Name = "Surname")]
        public string surname { get; set; }

        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Balance")]
        public decimal balance { get; set; }

        public virtual ApplicationUser user { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual  ICollection<transactions> transaction { get; set; }

        public virtual ICollection<bids> bid { get; set; }
    }
}