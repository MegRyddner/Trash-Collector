﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string UserName { get; set; }
        [Display(Name ="User Name")]
        public string Email { get; set; }

        [Display(PhoneNumber ="Phone Number")]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        //[ForeignKey("city")]

        //public int? CityId { get; set; }
        //public City city { get; set; }

        //[ForeignKey("state")]
        //public int? StateId { get; set; }
        //public State state { get; set; }
        //public string State { get; set; }

     
        [ForeignKey("residence")]
        public int? ResidenceTypeId { get; set; }
        
        public double? latitude { get; set; }
        public double? longitude { get; set; }
        

        [Display(Name = "Pick Up Day")]
        public int? PickUpDayId { get; set; }

        
        [Display(Name ="Requested Extra Pick Up Day")]
        public int? ExtraRequestedDayId { get; set; }
        
        
        [DisplayFormat(DataFormatString = "{0:0.###}")]
        public double? amountDue { get; set; }
        public DateTime DueDate { get; set; }
        [Display(Name ="Total Paid")]
        public double? TotalPaid { get; set; }

        [ForeignKey ("ApplicationUser")]
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        
      
       
        public string AppUserID { get; internal set; }
        public object CustomerID { get; internal set; }
        public bool PickupStatus { get; internal set; }
        public int BalanceDue { get; internal set; }
    }
}