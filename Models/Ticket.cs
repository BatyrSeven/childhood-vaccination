﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Playground.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int Room { get; set; }
        [Required]
        public string DoctorFullName { get; set; }
        [Required]
        public string Diagnosis { get; set; }
        public string Prescription { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public TimeSpan Time { get; set; }
        public int DoctorId { get; set; }
        public DateTime EndDate { get; set; }
    }
}
