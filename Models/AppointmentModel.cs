using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppointmentMaker.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(20, MinimumLength = 4)]
        [DisplayName("Patient's full name")]
        public string PatientName { get; set; }

        [StringLength(40, MinimumLength = 4)]
        [DisplayName("Patient's street")]
        public string? PatientStreet { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [DisplayName("Patient's city")]
        public string? PatientCity { get; set; }

        [StringLength(10, MinimumLength = 2)]
        [DisplayName("Patient's ZIP code")]
        public string? PatientZIP { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 4)]
        [DisplayName("Patient's email")]
        public string PatientEmail { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 5)]
        [DisplayName("Patient's phone number")]
        public int PatientPhone { get; set; }

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
