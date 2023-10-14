using Microsoft.AspNetCore.Mvc;
using WiseProject.Business.Abstract;

namespace WiseProject.Controllers
{
    public class EnrollmentController : Controller
    {

        IEnrollmentService _enrollmentService;
        public EnrollmentController(IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }


        public IActionResult Delete(int id)
        {
            return View(_enrollmentService.Get(id).Data);
        }

        public IActionResult Edit(int id)
        {
            return View(_enrollmentService.Get(id).Data);
        }
    }
}
