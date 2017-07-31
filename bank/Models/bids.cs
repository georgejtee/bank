using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace bank.Models
{
    public class bids
    {
        public int id { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int amount { get; set; }

        public int quantity { get; set; }

        [Required]
        public int CheckingAccountId { get; set; }

        public virtual CheckingAccount checkingaccount { get; set; }

        // public virtual ICollection<transactions> transaction { get; set; }
    }
}