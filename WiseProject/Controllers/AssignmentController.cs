using Microsoft.AspNetCore.Mvc;
using WiseProject.Business.Abstract;
using WiseProject.Models;

namespace WiseProject.Controllers
{
    public class AssignmentController : Controller
    {
        IAssignmentService _assignmentService;
        public AssignmentController(IAssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }

        public IActionResult Delete(int id)
        {
            return View(_assignmentService.Get(id).Data);
        }
       
        public IActionResult Edit(int id)
        {
            return View(_assignmentService.Get(id).Data);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _assignmentService.Delete(id);
            return RedirectToAction("Index", "Course");
        }

        [HttpPost]
        public IActionResult Edit(Assignment assignment)
        {
            _assignmentService.Update(assignment);
            return View(assignment);
        }
    }
}
