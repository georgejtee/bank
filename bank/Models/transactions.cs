using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bank.Models
{
    public class transactions
    {
        public int id { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal amount { get; set; }

        [Required]
        public int CheckingAccountId { get; set; }

        public virtual CheckingAccount checkingaccount { get; set; }
    }


}