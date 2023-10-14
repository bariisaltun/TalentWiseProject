using WiseProject.Business.Abstract;
using WiseProject.Business.Constants;
using WiseProject.DAL.Abstract;
using WiseProject.Models;
using WiseProject.Data.Results;
using IResult = WiseProject.Data.Results.IResult;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Web;

namespace WiseProject.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private ICourseDal _courseDal;
        private readonly ICurrentUserService _currentUser;
        private IAssignmentService _assignmentService;

        public CourseManager(ICourseDal courseDal, ICurrentUserService currentUser, IAssignmentService assignmentService)
        {
            _courseDal = courseDal;
            _currentUser = currentUser;
            _assignmentService = assignmentService;
        }

        public IResult Add(Course course)
        {
            course.UserId = _currentUser.UserId();
            _courseDal.Add(course);
            return new SuccessResult();
        }

        public IResult Delete(int courseId)
        {
            var course = _courseDal.Get(x => x.Id == courseId);
            
            _courseDal.Delete(course);
            return new SuccessResult();
        }

        public IResult AddAssignment(Assignment assignment)
        {
           // assignment.CourseId = courseId; 
            _assignmentService.Add(assignment);
            return new SuccessResult();
        }

        public IDataResult<Course> Get(int id)
        {
            var course = _courseDal.Get(x => x.Id == id);
            course.Assignment = _assignmentService.GetListByCourseId(course.Id).Data;
            return new SuccessDataResult<Course>(course, Messages.ItemsListed);
        }

        public IDataResult<List<Course>> GetList(int page,int maxRows)
        {
            var courses = _courseDal.GetList().Skip((page - 1) * maxRows).Take(maxRows).ToList();
            if(courses.Count()==0)
                return new ErrorDataResult<List<Course>>(Messages.ItemNotFound);

            return new SuccessDataResult<List<Course>>(courses, Messages.ItemsListed);
        }

        public IResult Update(Course course)
        {
            course.UserId = _currentUser.UserId();
            _courseDal.Update(course);
            return new SuccessResult();
        }
    }
}
