using framework_deneme.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework_deneme.Dal.Repositories.Abstract
{
   public interface IPersonnelRepository:IRepository<Personnel>
    {
         IEnumerable<Personnel> GetPersonnelsWithDepartments();
    }
}
