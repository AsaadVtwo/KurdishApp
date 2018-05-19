// ====================================================
// More Templates: https://www.ebenmonney.com/templates
// Email: support@ebenmonney.com
// ====================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.Repositories.Interfaces;
using KurdishApp.Data.Repositories;

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
        

        public ITeacherRepository Products
        {
            get
            {
                if (_teacher == null)
                    _teacher = new TeacherRepository(_context);

                return _teacher;
            }
        }

        

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
