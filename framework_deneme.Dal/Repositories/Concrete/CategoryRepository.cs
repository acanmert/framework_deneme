using framework_deneme.Dal.Repositories.Abstract;
using framework_deneme.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework_deneme.Dal.Repositories.Concrete
{
    public class CategoryRepository : Repository<Category> , ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }

        public PersonnelContext PersonnelContext { get { return _context as PersonnelContext; } }
    }
}
