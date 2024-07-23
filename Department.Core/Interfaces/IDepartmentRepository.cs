﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Core.Interfaces
{
    public interface IDepartmentRepository
    {
        public Task AddDepartment(Department.Core.DomainEnties.Department NewDepartment, int parentDepartment);
        public Task<List<Department.Core.DomainEnties.Department>> GetDepartments(int parentDepartmentId);
        public Task<int> Commit();
    }
}