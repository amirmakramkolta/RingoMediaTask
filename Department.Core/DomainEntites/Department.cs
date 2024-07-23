using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Core.DomainEnties
{
    public class Department
    {
        private Department()
        {

        }
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Logo { get; private set; }
        public Department ParentDepartment { get; private set; }
        public IEnumerable<Department> ChildDepartment { get; private set; }
        public int? ParentDpartmentId { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public static Department CreateNewDepartment(string Name, string Logo, int? ParentDpartmentId = null)
        {
            var NewDepartment = new Department() 
            { 
                Name = Name,
                Logo = Logo,
                ParentDpartmentId = ParentDpartmentId,
                CreatedAt = DateTime.Now,
            };
            return NewDepartment;
        }
    }
}
