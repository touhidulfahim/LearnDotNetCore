using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyFirstApp.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly DbContext _context;
        public UnitOfWork(DbContext context) => _context = context;
        public void Dispose() => _context?.Dispose();
        public void Save() => _context?.SaveChanges();
        public void SaveAsync() => _context?.SaveChangesAsync();
    }
}
