using WiseProject.Data.Results;
using WiseProject.Models;
using IResult = WiseProject.Data.Results.IResult;

namespace WiseProject.Business.Abstract
{
    public interface IAssignmentService
    {
        IDataResult<List<Assignment>> GetListByCourseId(int courseId);

        IDataResult<Assignment> Get(int id);
        IResult Add(Assignment enrollment);
        IResult Update(Assignment enrollment);
        IResult Delete(int enrollmentId);
    }
}
