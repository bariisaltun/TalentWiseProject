using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WiseProject.Business.Abstract;
using WiseProject.Models;

namespace WiseProject.Controllers
{
    public class CourseController : Controller
    {
        ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index(int id =1)
        {
           // var c = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var b = User.Identity.Name;
            int max = 6;

            return View(_courseService.GetList(id, max).Data);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View(_courseService.Get(id).Data);
        }
        public IActionResult Delete(int id)
        {
            return View(_courseService.Get(id).Data);
        }
        public IActionResult Edit(int id)
        {
            return View(_courseService.Get(id).Data);
        }
        [HttpPost]
        public IActionResult Edit(Course course)
        {
            var result = _courseService.Update(course);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Create(Course course)
        {
            var result = _courseService.Add(course);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var result = _courseService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateAssignment(int id)
        {
            return View(new Assignment() { CourseId = id});
        }

        [HttpPost]
        public IActionResult CreateAssignment(Assignment assignment)
        {
            var result = _courseService.AddAssignment(assignment);
            return RedirectToAction(nameof(Index));
        }
    }
}
