using WiseProject.DAL.Abstract;
using WiseProject.DAL.EntityFramework;
using WiseProject.Data;
using WiseProject.Models;

namespace WiseProject.DAL.Concrete
{
    public class UserRoleDal : EfEntityRepositoryBase<UserRole, ApplicationDbContext>, IUserRoleDal
    {
    }
}
