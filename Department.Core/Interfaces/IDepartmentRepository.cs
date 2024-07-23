namespace Department.Core.Interfaces
{
    public interface IDepartmentRepository
    {
        public Task AddDepartment(string Name, string logo, int? parentDepartment, CancellationToken token);
        public Task<List<DomainEnties.Department>> GetDepartments(int? parentDepartmentId, CancellationToken token);
        public Task<DomainEnties.Department> GetDepartmentByid(int Id, CancellationToken token);
        public Task<int> Commit(CancellationToken token);
    }
}
