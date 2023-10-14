using WiseProject.Data.Results;
using WiseProject.Models;
using IResult = WiseProject.Data.Results.IResult;

namespace WiseProject.Business.Abstract
{
    public interface IEnrollmentService
    {
        //IDataResult<List<Enrollment>> GetListByCourseId(int courseId);

        IDataResult<Enrollment> Get(int id);
        IResult Add(Enrollment assignment);
        IResult Update(Enrollment assignment);
        IResult Delete(int assignmentId);
    }
}
