using ToolGiamSatNguoiRaVaoCang.Models;

namespace ToolGiamSatNguoiRaVaoCang.Repository.IRepository
{
    public interface IPersonRepository
    {
        public Task<Person> CreateAsync(Person obj);
        public Task<Person> UpdateAsync(Person obj);
        public Task<bool> DeleteAsync(int id);
        public Task<Person> GetAsync(int id);
        public Task<IEnumerable<Person>> GetAllAsync();
    }
}
