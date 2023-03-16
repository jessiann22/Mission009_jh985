﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission009_jh985.Models
{
    public class Donationcs
    {
        [Key]
        [BindNever]
        public int DonationId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage ="Please enter a name:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an Address:")] public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Please enter a City:")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a State:")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a Zip:")]
        public int Zip { get; set; }

        [Required(ErrorMessage = "Please enter a Country:")]
        public string Country { get; set; }

        public bool Anonymous { get; set; }

    }
}
