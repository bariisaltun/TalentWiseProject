using WiseProject.Business.Abstract;
using WiseProject.Business.Constants;
using WiseProject.DAL.Abstract;
using WiseProject.Data.Results;
using WiseProject.Models;

namespace WiseProject.Business.Concrete
{
    public class EnrollmentManager : IEnrollmentService
    {
        private IEnrollmentDal _enrollmentDal;
        private readonly ICurrentUserService _currentUser;
        public EnrollmentManager(IEnrollmentDal enrollmentDal, ICurrentUserService currentUser)
        {
            _enrollmentDal = enrollmentDal;
            _currentUser = currentUser;
        }

        public Data.Results.IResult Add(Enrollment enrollment)
        {
            var userId = _currentUser.UserId();
            var enroll = _enrollmentDal.Get(x => x.UserId == userId && x.CourseId==enrollment.CourseId);
            if (enroll != null)
            {
                return new ErrorResult();
            }
            enrollment.UserId = userId;
            enrollment.EnrollmentDate = DateTime.Now;
            _enrollmentDal.Add(enrollment);
            return new SuccessResult();
        }

        public Data.Results.IResult Delete(int enrollmentId)
        {
            var enroll = _enrollmentDal.Get(x => x.Id == enrollmentId);

            _enrollmentDal.Delete(enroll);
            return new SuccessResult();
        }

        public IDataResult<Enrollment> Get(int id)
        {
            var enroll = _enrollmentDal.Get(x => x.Id == id);
            return new SuccessDataResult<Enrollment>(enroll, Messages.ItemsListed);
        }

        public Data.Results.IResult Update(Enrollment enrollment)
        {
            _enrollmentDal.Update(enrollment);
            return new SuccessResult();
        }
    }
}
