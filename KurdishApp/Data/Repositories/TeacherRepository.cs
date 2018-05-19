// ====================================================
// More Templates: https://www.ebenmonney.com/templates
// Email: support@ebenmonney.com
// ====================================================

using Microsoft.EntityFrameworkCore;
using Kurdish.Models;
using KurdishApp.Data.Repositories.Interfaces;

namespace KurdishApp.Data.Repositories
{
    public class TeacherRepository : Repository<Teachers>, ITeacherRepository
    {
        public TeacherRepository(DbContext context) : base(context)
        { }


        
        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;
    }
}
