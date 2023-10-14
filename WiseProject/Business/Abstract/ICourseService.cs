
using WiseProject.Models;
using WiseProject.Data.Results;
using IResult = WiseProject.Data.Results.IResult;

namespace WiseProject.Business.Abstract
{
    public interface ICourseService
    {
        IDataResult<List<Course>> GetList(int page, int maxRows);
        IDataResult<Course> Get(int id);
        IResult Add(Course course);
        IResult Update(Course course);
        IResult Delete(int courseId);

        IResult AddAssignment(Assignment assignment);
    }
}
