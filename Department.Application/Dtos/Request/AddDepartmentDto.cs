using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Application.Dtos.Request
{
    public class AddDepartmentDto
    {
        public string DepartmentName { get; set; }
        public string logo { get; set; }
        public int ParentDepartmentId { get; set; }
    }
}
