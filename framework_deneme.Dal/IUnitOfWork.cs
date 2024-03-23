using framework_deneme.Dal.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework_deneme.Dal
{
    public interface IUnitOfWork:IDisposable
    {
        IDepartmentRepository DepartmentRepository { get;  }
        IPersonnelRepository PersonnelRepository { get;  }
        ICategoryRepository CategoryRepository { get; }
        int Complete();
    }
}
