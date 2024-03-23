using framework_deneme.Dal.Repositories.Abstract;
using framework_deneme.Dal.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework_deneme.Dal
{
    public class UnitOfWork : IUnitOfWork
    {
        PersonnelContext _personnelContext;
        public UnitOfWork(PersonnelContext context)
        {
            _personnelContext = context;
            DepartmentRepository = new DepartmentRepository(_personnelContext);
            PersonnelRepository = new PersonnelRepository(_personnelContext);
            CategoryRepository = new CategoryRepository(_personnelContext);

        }

        public IDepartmentRepository DepartmentRepository { get; private set; }
        public IPersonnelRepository PersonnelRepository { get; private set; }

        public ICategoryRepository CategoryRepository { get; private set; }

        public int Complete()
        {
            return _personnelContext.SaveChanges();
        }

        public void Dispose()
        {
            _personnelContext.Dispose();
        }
    }
}
