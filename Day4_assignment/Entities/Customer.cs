using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day4_assignment.Entities
{
    [Table ("Customer")]
    public class Customer
    {
        [Key]
        [StringLength(5)]
        public string cid { get; set; }
        [StringLength(25)]
        [Required]
        public string cname { get; set; }
        [Required]
        [RegularExpression("(^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$)")]
        public string email { get; set; }
        [Required]
        [RegularExpression("\\A[0 - 9]{10}\\z")]
        public string phone { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public DateTime dob { get; set; }

    }
}
