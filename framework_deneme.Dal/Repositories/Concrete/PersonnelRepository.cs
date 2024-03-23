using framework_deneme.Core;
using framework_deneme.Dal.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework_deneme.Dal.Repositories.Concrete
{
    public class PersonnelRepository : Repository<Personnel>,IPersonnelRepository
    {
        public PersonnelRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Personnel> GetPersonnelsWithDepartments()
        {
            return PersonnelContext.Personnels.ToList();
        }
        public PersonnelContext PersonnelContext{ get {return _context as PersonnelContext; } }
    }
}
