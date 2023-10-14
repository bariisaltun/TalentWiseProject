using WiseProject.DAL.Abstract;
using WiseProject.DAL.EntityFramework;
using WiseProject.Data;
using WiseProject.Models;

namespace WiseProject.DAL.Concrete
{
    public class RoleDal : EfEntityRepositoryBase<Role, ApplicationDbContext>, IRoleDal
    {
    }
}
