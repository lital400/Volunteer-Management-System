﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VMS.Models
{
    public class Opportunity
    {
        public int Id { get; set; }

        [Required]
        public string OpportunityName { get; set; }

        [Required]
        public DateTime DatePosted { get; set; }

        public string VolunteerPrefersCenter { get; set; }
        
        public bool IsOpen { get; set; }

        [Required]
        public int VolunteerId{ get; set; }
        [ForeignKey("VolunteerId")] public Volunteer Volunteer { get; set; }

    }
}