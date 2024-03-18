using WebApplication1.Models;

namespace WebApplication1.Contracts
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();

    }
}
