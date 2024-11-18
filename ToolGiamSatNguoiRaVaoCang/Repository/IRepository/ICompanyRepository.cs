using ToolGiamSatNguoiRaVaoCang.Models;

namespace ToolGiamSatNguoiRaVaoCang.Repository.IRepository
{
    public interface ICompanyRepository
    {
        public Task<Company> CreateAsync(Company obj);
        public Task<Company> UpdateAsync(Company obj);
        public Task<bool> DeleteAsync(int id);
        public Task<Company> GetAsync(int id);
        public Task<IEnumerable<Company>> GetAllAsync();
    }
}
