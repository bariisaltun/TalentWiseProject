using WiseProject.DAL.EntityFramework;
using WiseProject.Models;

namespace WiseProject.DAL.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<Role> GetClaims(User userInfo);
    }
}
