using WiseProject.Business.Abstract;
using WiseProject.Business.Constants;
using WiseProject.DAL.Abstract;
using WiseProject.Data.Results;
using WiseProject.Models;

namespace WiseProject.Business.Concrete
{
    public class AssignmentManager : IAssignmentService
    {
        IAssignmentDal _assignmentDal;
        public AssignmentManager(IAssignmentDal assignmentDal)
        {
            _assignmentDal = assignmentDal;
        }

        public Data.Results.IResult Add(Assignment assignment)
        {
            _assignmentDal.Add(assignment);
            return new SuccessResult();
        }

        public Data.Results.IResult Delete(int assignmentId)
        {
            var assig = _assignmentDal.Get(x => x.Id == assignmentId);

            _assignmentDal.Delete(assig);
            return new SuccessResult();
        }

        public IDataResult<Assignment> Get(int id)
        {
            var assignment = _assignmentDal.Get(x => x.Id == id);
            return new SuccessDataResult<Assignment>(assignment, Messages.ItemsListed);
        }

        public IDataResult<List<Assignment>> GetListByCourseId(int courseId)
        {
            var assig = _assignmentDal.GetList(x => x.CourseId == courseId).ToList();

            if (assig.Count() == 0)
                return new ErrorDataResult<List<Assignment>>(assig,Messages.ItemNotFound);

            return new SuccessDataResult<List<Assignment>>(assig, Messages.ItemsListed);
        }

        public Data.Results.IResult Update(Assignment assignment)
        {
            _assignmentDal.Update(assignment);
            return new SuccessResult();
        }
    }
}
