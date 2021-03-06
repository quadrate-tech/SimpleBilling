﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleBilling.Model
{
    public class Supplier : BaseEntity
    {
        [Key]
        public int SupplierId { get; set; }
        [MaxLength(150)]
        [Required]
        [Index(IsUnique = true)]
        public string Name { get; set; }
        [MaxLength(25)]
        [Required]
        public string Contact { get; set; }
        public string Address { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public float PendingAmount { get; set; }
        public virtual ICollection<GrnHeader> GRNHeaders { get; set; }

    }
}
