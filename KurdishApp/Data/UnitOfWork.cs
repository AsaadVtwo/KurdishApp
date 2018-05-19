// ====================================================
// More Templates: https://www.ebenmonney.com/templates
// Email: support@ebenmonney.com
// ====================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KurdishApp.Data.Repositories;
using KurdishApp.Data.Repositories.Interfaces;


namespace KurdishApp.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ApplicationDbContext _context;

       
        ITeacherRepository _teacher;
      



        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        

        public ITeacherRepository Teachers
        {
            get
            {
                if (_teacher == null)
                    _teacher = new TeacherRepository(_context);

                return _teacher;
            }
        }

        

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
