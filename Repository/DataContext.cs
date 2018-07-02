using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO.Domain;
using TODO.Domain.Concrete;

namespace Repository
{
    public class DataContext<TContext> where TContext : DbContext, IDbContext, new()
    {
        private readonly IDbContext _context;
        public DataContext()
        {
            _context = new TContext();
        }
    }
}
