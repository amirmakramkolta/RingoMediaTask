using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Core.DomainEnties
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public Department ParentDepartment { get; set; }
        public IEnumerable<Department> ChildDepartment { get; set; }
        public int? ParentDpartmentId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
