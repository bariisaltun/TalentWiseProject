using WiseProject.DAL.Abstract;
using WiseProject.DAL.EntityFramework;
using WiseProject.Data;
using WiseProject.Models;

namespace WiseProject.DAL.Concrete
{
    public class UserDal : EfEntityRepositoryBase<User, ApplicationDbContext>, IUserDal
    {
        public List<Role> GetClaims(User user)
        {
            using (var context = new ApplicationDbContext())
            {
               var result = from roles in context.Roles
                            join userRoles in context.UserRoles
                                on roles.Id equals userRoles.RoleId
                            where userRoles.UserId == user.Id
                            select new Role { Id = roles.Id, Name = roles.Name };

                return result.ToList();
            }
        }
    }
}
