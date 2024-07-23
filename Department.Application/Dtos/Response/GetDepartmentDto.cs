using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Application.Dtos.Response
{
    public class GetDepartmentDto
    {
        public int Id { get; set; }
        public int? ParentDepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Logo { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
