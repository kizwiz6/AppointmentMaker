using AppointmentMaker.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentMaker.Controllers
{
    public class AppointmentController : Controller
    {
        /// <summary>
        /// Need a list of things we're managing.
        /// When the controller is launched it creates a new list.
        /// List of AppointmentModel (type) called appointments.
        /// Static so it sticks around between different calls, it doesn't change.
        /// </summary>
        static List<AppointmentModel> appointments = new List<AppointmentModel>();

        /// <summary>
        /// Show a list (which will be Index).
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(appointments); // send a list of appointments.
        }

        /// <summary>
        /// Create a view for the create option. Creates a new appointment.
        /// The Create menu currently shows the create form. It goes to the details item.
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Shows the details of one item.
        /// Sends a piece of data. I nthe parentheses we are expecting to receive an appointment model.
        /// </summary>
        /// <returns></returns>
        public IActionResult Details(AppointmentModel appointment)
        {
            appointments.Add(appointment); // add new appointment to appointment list.
            return View("Details", appointment);
        }
    }
}
