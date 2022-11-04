using System.ComponentModel;

namespace AppointmentMaker.Models
{
    public class AppointmentModel
    {
        [DisplayName("Patient's full name")]
        public string PatientName { get; set; }

        [DisplayName("Appointment Request Date")]
        public DateTime AppointmentDate { get; set; }

        [DisplayName("Patient's Approximate Net Worth")]
        public decimal PatientNetWorth { get; set; }

        [DisplayName("Primary Doctor's Last Name")]
        public string DoctorName { get; set; }

        [DisplayName("Patient's Perceived Level of Pain (1 low to 10 higH)")]
        public int PainLevel { get; set; }
    }
}
