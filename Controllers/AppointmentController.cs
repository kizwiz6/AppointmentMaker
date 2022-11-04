using AppointmentMaker.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentMaker.Controllers
{
    public class AppointmentController : Controller
    {
        /// <summary>
        /// Show a list (which will be Index).
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Create a view for the create option. Creates a new appointment.
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
            return View("Details", appointment);
        }
    }
}
