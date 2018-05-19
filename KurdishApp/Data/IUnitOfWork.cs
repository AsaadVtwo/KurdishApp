// ====================================================
// More Templates: https://www.ebenmonney.com/templates
// Email: support@ebenmonney.com
// ====================================================


using KurdishApp.Data.Repositories.Interfaces;
using System.Threading.Tasks;

namespace KurdishApp.Data
{
    public interface IUnitOfWork
    {
      
        ITeacherRepository Teachers { get; }



        Task<int> SaveChangesAsync();
    }
}
