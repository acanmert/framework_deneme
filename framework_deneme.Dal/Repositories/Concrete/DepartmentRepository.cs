﻿using framework_deneme.Core;
using framework_deneme.Dal.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework_deneme.Dal.Repositories.Concrete
{
    public class DepartmentRepository:Repository<Department>,IDepartmentRepository
    {
        
        public DepartmentRepository(PersonnelContext context):base(context)
        {
           
        }

        public IEnumerable<Department> GetDepartmentsWithPersonels()
        {
            return PersonnelContext.Departments.ToList();
        }

        public IEnumerable<Department> GetTopDepartments(int count)
        {
            return PersonnelContext.Departments.Take(count);
        }
        public PersonnelContext PersonnelContext{ get { return _context as PersonnelContext; } }
    }   

}
