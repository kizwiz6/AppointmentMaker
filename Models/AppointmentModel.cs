﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppointmentMaker.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(20, MinimumLength = 4)]
        [DisplayName("Patient's full name")]
        public string PatientName { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Appointment Request Date")]
        public DateTime AppointmentDate { get; set; }

        [DataType(DataType.Currency)]
        [DisplayName("Patient's Approximate Net Worth")]
        public decimal PatientNetWorth { get; set; }

        [DisplayName("Primary Doctor's Last Name")]
        public string? DoctorName { get; set; }

        [Range(1,10)]
        [DisplayName("Patient's Perceived Level of Pain (1 low to 10 higH)")]
        public int PainLevel { get; set; }
    }
}
