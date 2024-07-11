using NORKRESEARCH.Models.Northwind;

namespace NORKRESEARCH.Northwind
{
    public interface INorthwindService
    {
        Task<List<EmployeesType>> GetEmployees();
    }
}
